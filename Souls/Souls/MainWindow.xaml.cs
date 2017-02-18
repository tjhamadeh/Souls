using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Souls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BLOODBORNE bb;
        private int lvl;
        private int lvl2Str
        {
            get { return lvl; }
            set
            {
                lvl = value;
                lvlBox.Text = value.ToString();
            }
        }
        private int str;
        private int str2Str
        {
            get { return str; }
            set
            {
                str = value;
                strBox.Text = value.ToString();
            }
        }
        private int dex;
        private int dex2Str
        {
            get { return dex; }
            set
            {
                dex = value;
                dexBox.Text = value.ToString();
            }
        }
        public MainWindow()
        {

            InitializeComponent();
            generateSoulList();
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void strBox_KeyDown(object sender, KeyEventArgs e)
        {
            int newStr;
            if (e.Key == Key.Enter && int.TryParse(strBox.Text, out newStr))
                checkStat(newStr, STATS_E.STRENGTH);
        }

        private void dexBox_KeyDown(object sender, KeyEventArgs e)
        {
            int newDex;
            if (e.Key == Key.Enter && int.TryParse(dexBox.Text, out newDex))
                checkStat(newDex, STATS_E.DEXTERITY);
        }

        private void addStrButton_Click(object sender, RoutedEventArgs e)
        {
            if (str2Str >= 99)
                return;
            str2Str++;
            lvl2Str++;
        }

        private void remStrButton_Click(object sender, RoutedEventArgs e)
        {
            switch ((SOULS_E)soulsList.SelectedIndex)
            {
                case SOULS_E.BLOODBORNE:
                    if (str2Str <= bb.selClass.getStr())
                    {
                        str2Str = bb.selClass.getStr();
                        // add level fixing logic ... ??? (actually maybe not)
                        return;
                    }
                    else if (lvl2Str <= bb.selClass.getLvl())
                    {
                        lvl2Str = bb.selClass.getLvl();
                        return;
                    }
                    break;
                case SOULS_E.DARKSOULS:
                    break;
                case SOULS_E.DARKSOULS2:
                    break;
                case SOULS_E.DARKSOULS3:
                    break;
            }

            str2Str--;
            lvl2Str--;
        }

        private void addDexButton_Click(object sender, RoutedEventArgs e)
        {
            if (dex2Str >= 99)
                return;
            dex2Str++;
            lvl2Str++;
        }

        private void remDexButton_Click(object sender, RoutedEventArgs e)
        {
            switch ((SOULS_E)soulsList.SelectedIndex)
            {
                case SOULS_E.BLOODBORNE:
                    if (dex2Str <= bb.selClass.getSkl())
                    {
                        dex2Str = bb.selClass.getSkl();
                        return;
                    }
                    else if (lvl2Str <= bb.selClass.getLvl())
                    {
                        lvl2Str = bb.selClass.getLvl();
                        return;
                    }
                    break;
                case SOULS_E.DARKSOULS:
                    break;
                case SOULS_E.DARKSOULS2:
                    break;
                case SOULS_E.DARKSOULS3:
                    break;
            }
            dex2Str--;
            lvl2Str--;
        }

        private void soulsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            classList.Items.Clear();
            classList.IsEnabled = true;
            switch ((SOULS_E)soulsList.SelectedIndex)
            {
                case SOULS_E.BLOODBORNE:
                    generateBloodborneList();
                    break;
                case SOULS_E.DARKSOULS:
                    classList.IsEnabled = false;
                    return;
                case SOULS_E.DARKSOULS2:
                    classList.IsEnabled = false;
                    return;
                case SOULS_E.DARKSOULS3:
                    classList.IsEnabled = false;
                    return;
            }
            classList.SelectedIndex = 0;
        }

        private void classList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            initializeClass(soulsList.SelectedIndex, classList.SelectedIndex);
        }

        private bool generateSoulList()
        {
            soulsList.SelectedIndex = 0;
            soulsList.Items.Add("Bloodborne");
            soulsList.Items.Add("Dark Souls");
            soulsList.Items.Add("Dark Souls 2");
            soulsList.Items.Add("Dark Souls 3");

            return true;
        }

        private bool generateBloodborneList()
        {
            classList.Items.Add("Milquetoast");
            classList.Items.Add("Lone Survivor");
            classList.Items.Add("Troubled Childhood");
            classList.Items.Add("Violent Past");
            classList.Items.Add("Professional");
            classList.Items.Add("Military Veteran");
            classList.Items.Add("Noble Scion");
            classList.Items.Add("Cruel Fate");
            classList.Items.Add("Waste of Skin");

            return true;
        }

        private bool initializeClass(int selectedSouls, int selectedClass)
        {
            switch ((SOULS_E)selectedSouls)
            {
                case SOULS_E.BLOODBORNE:
                    bb = new BLOODBORNE(selectedClass);
                    lvl2Str = bb.selClass.getLvl();
                    str2Str = bb.selClass.getStr();
                    dex2Str = bb.selClass.getSkl();
                    // more to come ...
                    break;
                case SOULS_E.DARKSOULS:
                    // not yet
                    break;
                case SOULS_E.DARKSOULS2:
                    // not yet
                    break;
                case SOULS_E.DARKSOULS3:
                    // not yet
                    break;
            }

            return true;
        }

        private bool checkStat(int newStat, STATS_E stat)
        {
            int curStat;
            int basStat;
            switch (stat)
            {
                default:
                case STATS_E.STRENGTH:
                    if (newStat > 99 || newStat < bb.selClass.getStr())
                    {
                        str2Str = str;
                        return false;
                    }
                    curStat = str2Str;
                    basStat = bb.selClass.getStr();
                    break;
                case STATS_E.DEXTERITY:
                case STATS_E.SKILL:
                    if (newStat > 99 || newStat < bb.selClass.getSkl())
                    {
                        dex2Str = dex;
                        return false;
                    }
                    curStat = dex2Str;
                    basStat = bb.selClass.getSkl();
                    break;
            }

            int diff = Math.Abs(curStat - newStat);
            if (newStat > curStat)
            {
                lvl2Str += diff;
            }
            else if (newStat == curStat)
            {
                return false;
            }
            else
            {
                if ((lvl2Str - diff) < bb.selClass.getLvl())
                {
                    lvl2Str = lvl;
                    newStat = curStat;
                }
                else if (newStat < basStat)
                {
                    lvl2Str = lvl;
                    newStat = curStat;
                }
                else
                {
                    lvl2Str -= diff;
                }
            }

            switch (stat)
            {
                default:
                case STATS_E.STRENGTH:
                    str2Str = newStat;
                    break;
                case STATS_E.DEXTERITY:
                case STATS_E.SKILL:
                    dex2Str = newStat;
                    break;
            }

            return true;
        }
    }

    public enum STATS_E : int
    {
        STRENGTH = 0,
        DEXTERITY,
        SKILL
    }

    public enum SOULS_E : int
    {
        BLOODBORNE = 0,
        DARKSOULS,
        DARKSOULS2,
        DARKSOULS3
    }

    public enum BLOODBORNE_E : int
    {
        MILQUETOAST = 0,
        LONESURVIVOR,
        TROUBLEDCHILDHOOD,
        VIOLENTPAST,
        PROFESSIONAL,
        MILITARYVETERAN,
        NOBLESCION,
        CRUELFATE,
        WASTEOFSKIN
    }

    public enum DARKSOULS1_E : int
    {
        WARRIOR = 0,
        KNIGHT,
        WANDERER,
        THIEF,
        BANDIT,
        HUNTER,
        SORCERER,
        PYROMANCER,
        CLERIC,
        DEPRIVED
    }

    public enum DARKSOULS2_E : int
    {
        WARRIOR = 0,
        KNIGHT,
        SWORDSMAN,
        BANDIT,
        CLERIC,
        SORCERER,
        EXPLORER,
        DEPRIVED
    }

    public enum DARKSOULS3_E : int
    {
        KNIGHT = 0,
        MERCENARY,
        WARRIOR,
        HERALD,
        THIEF,
        ASSASSIN,
        SORCERER,
        PYROMANCER,
        CLERIC,
        DEPRIVED
    }
}
