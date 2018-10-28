using System;
using System.Collections.Generic;
using System.Windows.Forms;

using GNaviDataClass;
using GNaviManager;

namespace GNaviMain
{
    public partial class MainForm : Form
    {
        private int page = 0;
        private ShowRestaurantDataClass _dcFull;
        private ShowRestaurantDataClass _dcDisp;
        private AreaRegionMasterDataClass _dcAreaRegionMaster;
        private AreaPrefMasterDataClass _dcAreaPrefectureMaster;
        private AreaSmallMasterDataClass _dcAreaSmallMaster;

        public MainForm()
        {
            InitializeComponent();

            _dcFull = new ShowRestaurantDataClass() { };
            _dcFull.restList = new List<ShowRestaurantItem>() { };
            _dcDisp = new ShowRestaurantDataClass() { };
            _dcDisp.restList = new List<ShowRestaurantItem>() { };
            _dcAreaRegionMaster = new AreaRegionMasterDataClass() { };
            _dcAreaRegionMaster.area = new List<Area>() { };
            _dcAreaPrefectureMaster = new AreaPrefMasterDataClass() { };
            _dcAreaPrefectureMaster.pref = new List<Pref>() { };
            _dcAreaSmallMaster = new AreaSmallMasterDataClass() { };
            _dcAreaSmallMaster.garea_small = new List<GareaSmall>() { };

            RegionListBox.Items.Clear();
            PrefectureListBox.Items.Clear();
            SmallAreaListBox.Items.Clear();
            SetRegionListBox();
        }

        private void SetRegionListBox()
        {
            _dcAreaRegionMaster.area.Clear();
            RegionListBox.Items.Clear();

            GuruguruNaviManager.GetRegionAreaMasterData(_dcAreaRegionMaster);
            foreach (Area a in _dcAreaRegionMaster.area)
            {
                RegionListBox.Items.Add(a.area_name);
            }
            RegionListBox.SelectedIndex = 0;
            Area selectedArea = _dcAreaRegionMaster.area[RegionListBox.SelectedIndex];
            SetPrefectureListBox(selectedArea.area_code);
        }

        private void SetPrefectureListBox(string RegionCode)
        {
            _dcAreaPrefectureMaster.pref.Clear();
            PrefectureListBox.Items.Clear();

            //一行目に「全て」を表示
            Pref pAll = new Pref() { };
            pAll.pref_name = "全て";
            pAll.pref_code = null;
            _dcAreaPrefectureMaster.pref.Add(pAll);

            GuruguruNaviManager.GetPrefAreaMasterData(RegionCode, _dcAreaPrefectureMaster);
            foreach (Pref p in _dcAreaPrefectureMaster.pref)
            {
                PrefectureListBox.Items.Add(p.pref_name);
            }
            PrefectureListBox.SelectedIndex = 0;
        }

        private void SetAreaSmallListBox(string PrefCode)
        {
            _dcAreaSmallMaster.garea_small.Clear();
            SmallAreaListBox.Items.Clear();

            //県で「全て」が選択されている場合
            if (string.IsNullOrEmpty(PrefCode))
            {
                return;
            }

            //一行目に「全て」を表示
            GareaSmall sAll = new GareaSmall() { };
            sAll.areaname_s = "全て";
            sAll.areacode_s = null;
            _dcAreaSmallMaster.garea_small.Add(sAll);

            GuruguruNaviManager.GetAreaSmallMasterData(PrefCode, _dcAreaSmallMaster);
            foreach (GareaSmall s in _dcAreaSmallMaster.garea_small)
            {
                SmallAreaListBox.Items.Add(s.areaname_s);
            }
            SmallAreaListBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadRestaurantData();
        }

        private ShowRestaurantItem GetShowData(int index, int page)
        {
            if (_dcDisp.restList.Count <= page * 3 + index)
            {
                return null;
            }
            else
            {
                return _dcDisp.restList[page * 3 + index];
            }
        }

        private int numRoundUp(double d, int baseNum)
        {
            return Convert.ToInt32(Math.Ceiling(d / baseNum));
        }

        private void DispPageCount()
        {
            pageCountLabel.Text = string.Empty;
            int sousuu = numRoundUp((double)_dcDisp.restList.Count, 3);
            int nowPage = page + 1;
            pageCountLabel.Text = $"{nowPage}ページ / {sousuu}ページ";
        }

        private void SetDataToComponent()
        {
            DispPageCount();
            dispRestaurantDataPanel1.Reload(GetShowData(0, page));
            dispRestaurantDataPanel2.Reload(GetShowData(1, page));
            dispRestaurantDataPanel3.Reload(GetShowData(2, page));

            if (page == 0)
            {
                PrevPageButton.Enabled = false;
            }
            else
            {
                PrevPageButton.Enabled = true;
            }
            if ((page + 1) == numRoundUp((double)_dcDisp.restList.Count, 3))
            {
                NextPageButton.Enabled = false;
            }
            else
            {
                NextPageButton.Enabled = true;
            }
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            page--;
            SetDataToComponent();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            page++;
            SetDataToComponent();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReloadRestaurantData();
        }
        private void ReloadRestaurantData()
        {
            SearchRestaurantInfo sRInfo = new SearchRestaurantInfo() { };
            sRInfo.rest = new Rest() { };
            sRInfo.DaysAgo = 14;
            sRInfo.rest.code = new Code() { };
            sRInfo.rest.code.areacode = _dcAreaRegionMaster.area[RegionListBox.SelectedIndex].area_code;
            sRInfo.rest.code.prefcode = _dcAreaPrefectureMaster.pref[PrefectureListBox.SelectedIndex].pref_code;
            if (sRInfo.rest.code.prefcode != null)
            {
                sRInfo.rest.code.areacode_s = _dcAreaSmallMaster.garea_small[SmallAreaListBox.SelectedIndex].areacode_s;
            }
            else
            {
                sRInfo.rest.code.areacode_s = null;
            }

            _dcFull.restList.Clear();
            GuruguruNaviManager.GetRestaurantData(sRInfo, _dcFull);
            page = 0;
            allRadioButton.Checked = true;
            ChangeDispList();
            SetDataToComponent();
        }

        private void RegionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPrefectureListBox(_dcAreaRegionMaster.area[RegionListBox.SelectedIndex].area_code);
        }

        private void SmallAreaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void PrefectureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAreaSmallListBox(_dcAreaPrefectureMaster.pref[PrefectureListBox.SelectedIndex].pref_code);
        }

        private void ChangeDispList()
        {
            if (allRadioButton.Checked)
            {
                _dcDisp.restList = _dcFull.restList;
            }
            else if (onlyNewRadioButton.Checked)
            {
                _dcDisp.restList = _dcFull.restList.FindAll(item => item.update_compare_leatest == item.update_compare_oldest);
            }
            else if (onlyUpdateRadioButton.Checked)
            {
                _dcDisp.restList = _dcFull.restList.FindAll(item => item.update_compare_leatest != item.update_compare_oldest);
            }
        }

        private void RadioButton_EnabledChanged(object sender, EventArgs e)
        {
            //ラジオボタンに応じて、リストを切り替える。
            //その後再表示
            ChangeDispList();
            page = 0;
            SetDataToComponent();
        }
    }
}
