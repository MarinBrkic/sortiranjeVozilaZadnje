using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sortiranjeVozila
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxKilometraza.Text) >= 0 &&
                    Convert.ToInt32(textBoxGodProizvodnje.Text) > -1)
                {

                    Vozilo vozilo = new Vozilo(textBoxMarka.Text, textBoxModel.Text,
                        Convert.ToInt32(textBoxGodProizvodnje.Text),
                        Convert.ToInt32(textBoxKilometraza.Text));

                    voziloList.Add(vozilo);
                    textBoxModel.Clear();
                    textBoxMarka.Clear();
                    textBoxGodProizvodnje.Clear();
                    textBoxKilometraza.Clear();
                    textBoxMarka.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
    "Pogrešan unos", MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                textBoxMarka.Clear();
                textBoxModel.Clear();
                textBoxGodProizvodnje.Clear();
                textBoxKilometraza.Clear();
                textBoxMarka.Focus();
            }

        }

        private void buttonSortiraj_Click(object sender, EventArgs e)
        {
            if (checkBoxUzlazno.Checked = false)
            {
                if (comboBoxFilter.Text == "Sve")
                {
                    foreach (Vozilo v in voziloList)
                    {
                        textBoxIspis.AppendText(v.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Marka")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Marka descending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Model")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Model descending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Godina Proizvodnje")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.GodinaProizvodnje descending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Kilometraza")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Kilometraza descending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
            }
            else
            {
                if (comboBoxFilter.Text == "Sve")
                {
                    foreach (Vozilo v in voziloList)
                    {
                        textBoxIspis.AppendText(v.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Marka")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Marka ascending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Model")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Model ascending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Godina Proizvodnje")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.GodinaProizvodnje ascending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
                else if (comboBoxFilter.Text == "Kilometraza")
                {
                    var sortiranaVozila =
                        from vozilo in voziloList
                        orderby vozilo.Kilometraza ascending
                        select vozilo;

                    foreach (var vozilo in sortiranaVozila)
                    {
                        textBoxIspis.AppendText(vozilo.ToString());
                    }
                }
            }
        }
        private void SaveToXml()
        {
            try
            {
                XElement vozilaElement = new XElement("Vozila",
                    voziloList.Select(v => new XElement("Vozilo",
                        new XElement("Marka", v.Marka),
                        new XElement("Model", v.Model),
                        new XElement("GodinaProizvodnje", v.GodinaProizvodnje),
                        new XElement("Kilometraza", v.Kilometraza)
                    ))
                );

                // Save the XML document to a file
                vozilaElement.Save("vozila.xml");
                MessageBox.Show("Vozila su uspešno sačuvana u XML!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri čuvanju XML: {ex.Message}");
            }
        }

        private void LoadFromXml()
        {
            try
            {
                // Load the XML document
                XElement vozilaElement = XElement.Load("vozila.xml");

                // Clear the existing list before loading new data
                voziloList.Clear();

                // Deserialize the XML into Vozilo objects and add to list
                var vozila = vozilaElement.Elements("Vozilo")
                    .Select(v => new Vozilo(
                        v.Element("Marka")?.Value,
                        v.Element("Model")?.Value,
                        Convert.ToInt32(v.Element("GodinaProizvodnje")?.Value),
                        Convert.ToInt32(v.Element("Kilometraza")?.Value)
                    )).ToList();

                voziloList.AddRange(vozila);
                MessageBox.Show("Vozila su uspešno učitana iz XML!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju XML: {ex.Message}");
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            textBoxIspis.Clear();
            voziloList.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToXml();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFromXml();
        }

        private void checkBoxUzlazno_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIspis.Clear();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIspis.Clear();
        }
    }
}
