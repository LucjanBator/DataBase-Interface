using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBaseInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
            textBox16.KeyDown += textBox16_KeyDown; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
        }
        private bool usedFinitiTable = false; // Flaga wskazująca, czy tabela 'datafiniti_fast_food_restaurants' była wykorzystana
        private bool usedSelect = false;
        private void button2_Click(object sender, EventArgs e)
        {
            usedFinitiTable = true;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button6.Visible = true;
            button9.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usedFinitiTable = false;
            button3.Visible = false;
            button2.Visible = false;
            button5.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button6.Visible = true;
            button9.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            if (usedFinitiTable)
            {
                label1.Visible = true;
            }
            else
            {
                label2.Visible = true;
            }
            textBox1.Visible = true;
            button8.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userInput = textBox1.Text;
                Display(userInput);
            }
        }

        private void Display(string input)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=LUCAbato1357!;database=restaurant"))
                {
                    con.Open();
                    string sqlQuery = $"SELECT DISTINCT `{input}` FROM {(usedFinitiTable ? "datafiniti_fast_food_restaurants" : "fastfoodrestaurants")}";
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    string inputs = $"{input}s:\n";
                    while (reader.Read())
                    {
                        inputs += reader[input] + "\t";
                        count++;
                        if (count % 20 == 0)
                        {
                            inputs += "\n";
                        }
                        if (count > 100) // Przerwij pętlę po wyświetleniu 100 linii
                        {
                            inputs += $"\n\n(Pokaż tylko pierwsze 100 linii)";
                            break;
                        }
                    }
                    if (count == 101)
                    {
                        MessageBox.Show("Ilość > 100\n" + inputs);
                    }
                    else
                    {
                        MessageBox.Show("Ilość " + input + " = " + count.ToString() + "\n" + inputs);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
            button8.Visible = false;
            button7.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            label19.Visible = false;
            textBox16.Visible = false;
            button9.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            textBox17.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
            button6.Visible = false;
            button9.Visible = false;
            label21.Visible = true;
            textBox17.Visible = true;
            if (usedFinitiTable)
            {
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
            }
            else
            {
                label4.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label18.Visible = true;
                textBox5.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox15.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (usedFinitiTable)
            {
                string column1Value = textBox2.Text;
                string column2Value = textBox3.Text;
                string column3Value = textBox4.Text;
                string column4Value = textBox5.Text;
                string column5Value = textBox6.Text;
                string column6Value = textBox7.Text;
                string column7Value = textBox8.Text;
                string column8Value = textBox17.Text;
                string column9Value = textBox9.Text;
                string column10Value = textBox10.Text;
                string column11Value = textBox11.Text;
                string column12Value = textBox12.Text;
                string column13Value = textBox13.Text;
                string column14Value = textBox14.Text;
                string column15Value = textBox15.Text;
                DodajRekordDoBazyDanych(column1Value, column2Value, column3Value,
             column4Value, column5Value, column6Value, column7Value, column8Value, column9Value, column10Value, column11Value, column12Value,
             column13Value, column14Value, column15Value);
            }
            else
            {
                string column1Value = textBox5.Text;
                string column2Value = textBox7.Text;
                string column3Value = textBox8.Text;
                string column4Value = textBox17.Text;
                string column5Value = textBox9.Text;
                string column6Value = textBox10.Text;
                string column7Value = textBox11.Text;
                string column8Value = textBox12.Text;
                string column9Value = textBox13.Text;
                string column10Value = textBox15.Text;
                DodajRekordDoBazyDanych2(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value, column9Value, column10Value);
            }

        }
        private void DodajRekordDoBazyDanych(string column1Value, string column2Value, string column3Value,
            string column4Value, string column5Value, string column6Value, string column7Value, string column8Value, string column9Value, string column10Value, 
            string column11Value, string column12Value, string column13Value, string column14Value, string column15Value)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=LUCAbato1357!;database=restaurant"))
                {
                    con.Open();

                    string sqlQuery = "INSERT INTO datafiniti_fast_food_restaurants (id, dateAdded, dateUpdated, address, categories, city, country, klucze, latitude, longitude, name, postalCode, province, sourceURLs, websites) " +
                        "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, @value12, @value13, @value14, @value15)";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    // Przypisanie wartości dla parametrów (@value1, @value2, ...) w zapytaniu SQL
                    cmd.Parameters.AddWithValue("@value1", column1Value);
                    cmd.Parameters.AddWithValue("@value2", column2Value);
                    cmd.Parameters.AddWithValue("@value3", column3Value);
                    cmd.Parameters.AddWithValue("@value4", column4Value);
                    cmd.Parameters.AddWithValue("@value5", column5Value);
                    cmd.Parameters.AddWithValue("@value6", column6Value);
                    cmd.Parameters.AddWithValue("@value7", column7Value);
                    cmd.Parameters.AddWithValue("@value8", column8Value); 
                    cmd.Parameters.AddWithValue("@value9", column9Value);
                    cmd.Parameters.AddWithValue("@value10", column10Value);
                    cmd.Parameters.AddWithValue("@value11", column11Value);
                    cmd.Parameters.AddWithValue("@value12", column12Value);
                    cmd.Parameters.AddWithValue("@value13", column13Value);
                    cmd.Parameters.AddWithValue("@value14", column14Value);
                    cmd.Parameters.AddWithValue("@value15", column15Value);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nowy rekord został dodany.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DodajRekordDoBazyDanych2(string column1Value, string column2Value, string column3Value,
            string column4Value, string column5Value, string column6Value, string column7Value, string column8Value, string column9Value, string column10Value)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=LUCAbato1357!;database=restaurant"))
                {
                    con.Open();

                    string sqlQuery = "INSERT INTO fastfoodrestaurants (address, city, country, klucze, latitude, longitude, name, postalCode, province, websites) " +
                        "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9, @value10)";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                    cmd.Parameters.AddWithValue("@value1", column1Value); 
                    cmd.Parameters.AddWithValue("@value2", column2Value);
                    cmd.Parameters.AddWithValue("@value3", column3Value);
                    cmd.Parameters.AddWithValue("@value4", column4Value);
                    cmd.Parameters.AddWithValue("@value5", column5Value);
                    cmd.Parameters.AddWithValue("@value6", column6Value);
                    cmd.Parameters.AddWithValue("@value7", column7Value);
                    cmd.Parameters.AddWithValue("@value8", column8Value);
                    cmd.Parameters.AddWithValue("@value9", column9Value);
                    cmd.Parameters.AddWithValue("@value10", column10Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nowy rekord został dodany.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            usedSelect = true;
            button6.Visible = false;
            button5.Visible = false; 
            button8.Visible = false;
            label19.Visible = true;
            button7.Visible = true;
            textBox16.Visible = true;
            button9.Visible = false;
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && usedSelect == true)
            {
                string userInput = textBox16.Text;
                WyświetlRekord(userInput);
            }
            if(e.KeyCode == Keys.Enter && usedSelect == false)
            {
                string userInput = textBox16.Text;
                UsuńRekord(userInput);
            }
        }
        private void WyświetlRekord(string wprowadzoneName)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=LUCAbato1357!;database=restaurant"))
                {
                    con.Open();
                    string sqlQuery = "";
                    if (usedFinitiTable)
                    {
                        sqlQuery = "SELECT * FROM `datafiniti_fast_food_restaurants` WHERE name = @wprowadzoneName";
                    }
                    else
                    {
                        sqlQuery = "SELECT * FROM `fastfoodrestaurants` WHERE name = @wprowadzoneName";
                    }
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@wprowadzoneName", wprowadzoneName);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Wyświetl rekord
                        string rekord = "";
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rekord += $"{reader.GetName(i)}: {reader[i]}\n";
                        }
                        MessageBox.Show(rekord);
                    }
                    else
                    {
                        MessageBox.Show("Rekord o podanym name nie został znaleziony.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            usedSelect = false;
            button9.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button8.Visible = false;
            textBox16.Visible = true;
            label20.Visible = true;
        }

        private void UsuńRekord(string wprowadzonaNazwa)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=LUCAbato1357!;database=restaurant"))
                {
                    con.Open();
                    string sqlQuery = ""; 

                    if (usedFinitiTable)
                    {
                        sqlQuery = "DELETE FROM `datafiniti_fast_food_restaurants` WHERE name = @wprowadzonaNazwa";
                    }
                    else
                    {
                        sqlQuery = "DELETE FROM `fastfoodrestaurants` WHERE name = @wprowadzonaNazwa";
                    }

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@wprowadzonaNazwa", wprowadzonaNazwa);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Rekord został pomyślnie usunięty.");
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono rekordu o podanej nazwie.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}        
