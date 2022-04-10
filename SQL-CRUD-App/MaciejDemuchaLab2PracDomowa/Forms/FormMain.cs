using MaciejDemuchaLab2PracDomowa.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace MaciejDemuchaLab2PracDomowa.Forms
{
    /// <summary>
    /// Klasa okna głównego aplikacji
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly Database.Repository _repository = new Repository();
        /// <summary>
        /// Konstruktor okna głownego aplikacji
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Aktualizacja danych w DataGridViewProducts przy ładowaniu okna
            RefreshDataGridViewProducts();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do dodawania produktu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string size = textBoxSize.Text;
            int price = int.Parse(textBoxPrice.Text);
            string sport = textBoxSport.Text;
            string type = textBoxType.Text;
            string sex = textBoxSex.Text;
            string producer = textBoxProducer.Text;
            string color = textBoxColor.Text;

            _repository.AddProduct(name, size, price, sport, type, sex, producer, color);

            RefreshDataGridViewProducts();
            ClearTextBoxes();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do usuwania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(textBoxId.Text);
            _repository.DeleteProduct(productId);

            RefreshDataGridViewProducts();
            ClearTextBoxes();
        }


        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od edycji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string size = textBoxSize.Text;
            int price = int.Parse(textBoxPrice.Text);
            int id = int.Parse(textBoxId.Text);
            string sport = textBoxSport.Text;
            string type = textBoxType.Text;
            string sex = textBoxSex.Text;
            string producer = textBoxProducer.Text;
            string color = textBoxColor.Text;

            _repository.EditProduct(id, name, size, price, sport, type, sex, producer, color);

            RefreshDataGridViewProducts();
            ClearTextBoxes();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od czyszczenia TextBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            int rowCount = dataGridViewProducts.SelectedRows.Count;
            if (rowCount == 0 || rowCount > 1)
            {
                return;
            }
            DataGridViewRow row = dataGridViewProducts.SelectedRows[0];

            int id = int.Parse(row.Cells[0].Value.ToString());
            string producer = row.Cells[1].Value.ToString();
            string sex = row.Cells[2].Value.ToString();
            string color = row.Cells[3].Value.ToString();
            string sport = row.Cells[4].Value.ToString();
            string type = row.Cells[5].Value.ToString();
            string name = row.Cells[6].Value.ToString();
            string size = row.Cells[7].Value.ToString();
            int price = int.Parse(row.Cells[8].Value.ToString());
            

            textBoxId.Text = id.ToString();
            textBoxName.Text = name;
            textBoxSize.Text = size;
            textBoxPrice.Text = price.ToString();
            textBoxType.Text = type;
            textBoxSex.Text = sex;
            textBoxSport.Text = sport;
            textBoxProducer.Text = producer;
            textBoxColor.Text = color;

        }

        
        /// <summary>
        /// Metoda czyszcząca wszystkie TextBoxy w oknie głównym
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxSize.Text = "";
            textBoxPrice.Text = "";
            textBoxSport.Text = "";
            textBoxType.Text = "";
            textBoxSex.Text = "";
        }

        /// <summary>
        /// Metoda odświeżająca dane w DataGridViewBooks
        /// </summary>
        private void RefreshDataGridViewProducts()
        {
            DataTable table = _repository.GetProducts();

            dataGridViewProducts.DataSource = table;
        }
    }
}
