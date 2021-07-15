using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if(cbAuthor.Text ==""||cbCarName.Text=="") {
                MessageBox.Show("記録者、又は車名を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    Auther = cbAuthor.Text,
                    Maker = selectedGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };
                listCarReport.Add(carReport);//1レコード追加
                setCbAuthor(cbAuthor.Text);
                setCbCarName(cbCarName.Text);
            }
        }
        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup() {

            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
            
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
            
        }
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgvRegistData_MouseClick(object sender, MouseEventArgs e) {
            //CarReport selectedCar = listCarReport[];
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            CarReport selectedCar = listCarReport[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Text.Equals(selectedCar.Maker.ToString())) {
                    ((RadioButton)item).Checked = true;
                }
            }

        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            if(dgvRegistData.CurrentCell != null) {
                listCarReport.RemoveAt(dgvRegistData.CurrentCell.RowIndex);
            }
            
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].Update(dtpDate.Value, cbAuthor.Text,selectedGroup(), cbCarName.Text, tbReport.Text, pbPicture.Image);
        }
    }
}
