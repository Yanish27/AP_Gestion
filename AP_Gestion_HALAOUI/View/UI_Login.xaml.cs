using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AP_Gestion_HALAOUI.BDD;
using AP_Gestion_HALAOUI.View;
using AP_Gestion_HALAOUI.DAO;
using AP_Gestion_HALAOUI.Controller;
namespace AP_Gestion_HALAOUI.View
{
    /// <summary>
    /// Logique d'interaction pour UI_Login.xaml
    /// </summary>
    public partial class UI_Login : UserControl
    {

        public UI_Login()
        {
            InitializeComponent();
        }

        private void BTN_Connexion_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Username.Text != "")
            {
                if (TB_Password.Password != "")
                {
                    Utilisateur utilisateur = new Utilisateur();
                    DAOEscapegame DAO = new DAOEscapegame();
                    if (DAO.CheckUsername(TB_Username.Text) == true)
                    {
                        if (DAO.CheckUsernamePassword(TB_Username.Text, TB_Password.Password) == true)
                        {
                            MessageBox.Show("OK");
                        } else
                        {
                            MessageBox.Show("Mot de passe incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cet utilisateur existe pas pas pas");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un mot de passe");
                }
            } else
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur");
            }
        }
    }
}
