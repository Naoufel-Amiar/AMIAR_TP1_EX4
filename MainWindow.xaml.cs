using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AMIAR_EX4
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void BT_CALCUL_Click(object sender, RoutedEventArgs e)
        {
            // dchaine de caractere crée en recuperant les valeur rentré par l'utilisateur
            string[] nombresEnTexte = TB_ENTREE_LISTE.Text.Split(' ');

            // Convertit les nombres en entiers et les stocke dans un tableau
            int[] tableau = nombresEnTexte.Select(int.Parse).ToArray();

            if (tableau.Length > 0)
            { //defini et renvoie valeur la plus basse
                int min = tableau.Min();
                int max = tableau.Max();
                //affiche la valeur la plus basse / haute
                TB_DISPLAY_2.Text = $"Le chiffre le plus bas est : {min} \n Le chiffre le plus élevé est : {max}";
            }
            else
            { //securité pour si l'entrée est vide
                TB_DISPLAY_2.Text = "Le tableau est vide.";
            }
        }
    }
}








    

