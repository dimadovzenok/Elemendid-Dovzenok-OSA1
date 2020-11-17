using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid_Dovzenok_osa1
{
    public partial class MainPage : ContentPage
    {
        private Picker stol;
        private void Stol_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public MainPage()
        {
            Picker picker;
            Entry entry;
            Image img;
            {
                Grid gr = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    }
                };
                picker = new Picker
                {
                    Title = "Уезды Эстонии"
                };
                picker.Items.Add("Валгамаа");
                picker.Items.Add("Вильяндимаа");
                picker.Items.Add("Вырумаа");
                picker.Items.Add("Ида-Вирумаа");
                picker.Items.Add("Йыгевамаа");
                picker.Items.Add("Ляэне-Вирумаа");
                picker.Items.Add("Ляэнемаа");
                picker.Items.Add("Пылвамаа");
                picker.Items.Add("Пярнумаа");
                picker.Items.Add("Рапламаа");
                picker.Items.Add("Сааремаа");
                picker.Items.Add("Тартумаа");
                picker.Items.Add("Харьюмаа");
                picker.Items.Add("Хийумаа");
                picker.Items.Add("Ярвамаа");
                gr.Children.Add(picker, 0, 0);
                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

                stol = new Picker
                {
                    Title = "Центры уездов"
                };
                stol.Items.Add("Валга");
                stol.Items.Add("Вильянди");
                stol.Items.Add("Выру");
                stol.Items.Add("Йихви");
                stol.Items.Add("Йигева");
                stol.Items.Add("Раквере");
                stol.Items.Add("Хаапсалу");
                stol.Items.Add("Пылва");
                stol.Items.Add("Пярну");
                stol.Items.Add("Рапла");
                stol.Items.Add("Курусааре");
                stol.Items.Add("Тарту");
                stol.Items.Add("Таллинн");
                stol.Items.Add("Кярдла");
                stol.Items.Add("Пайде");
                gr.Children.Add(stol, 0, 0);

                stol.SelectedIndexChanged += Stol_SelectedIndexChanged;
        

                entry = new Entry
                {
                    Text = "Уезд"
                };
                gr.Children.Add(entry, 1, 1);

                img = new Image
                {
                    Source = "harju.png"
                };
                {
                    if (stol.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 2)
                    {
                        img.Source = "võru.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 3)
                    {
                        img.Source = "ida.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 4)
                    {
                        img.Source = "jõgeva.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 5)
                    {
                        img.Source = "lääne.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 6)
                    {
                        img.Source = "laanemaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 7)
                    {
                        img.Source = "põlva.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 8)
                    {
                        img.Source = "pärnu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 9)
                    {
                        img.Source = "rapla.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 10)
                    {
                        img.Source = "saaremaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 11)
                    {
                        img.Source = "tartu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 12)
                    {
                        img.Source = "harju.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 13)
                    {
                        img.Source = "hiiu.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                    else if (stol.SelectedIndex == 14)
                    {
                        img.Source = "jaarvamaa.png";
                        picker.Title = picker.Items[stol.SelectedIndex];
                    }
                }
                {
                    if (picker.SelectedIndex == 0)
                    {
                        img.Source = "valga.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Валгамаа — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Валга.";
                    }
                    else if (picker.SelectedIndex == 1)
                    {
                        img.Source = "viljandi.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ви́льяндимаа — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Вильянди.";
                    }
                    else if (picker.SelectedIndex == 2)
                    {
                        img.Source = "võru.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Вырумаа — уезд в Эстонии, расположенный в юго-восточной части страны. Граничит с Россией, Латвией, уездами Валгамаа и Пылвамаа.";
                    }
                    else if (picker.SelectedIndex == 3)
                    {
                        img.Source = "ida.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "И́да-Ви́румаа , или И́да-Ви́руский уезд  — уезд  на северо-востоке Эстонии, граничит на севере и востоке с Россией. Территория уезда простирается до Финского залива на севере, до реки Нарвы на востоке и до Чудского озера на юге.";
                    }
                    else if (picker.SelectedIndex == 4)
                    {
                        img.Source = "jõgeva.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Йыгевамаа  — уезд в Эстонии, расположенный в восточной части страны. Административный центр — город Йыгева.  ";
                    }
                    else if (picker.SelectedIndex == 5)
                    {
                        img.Source = "lääne.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ля́эне-Ви́румаа  — уезд в Эстонии, расположенный в северо-восточной части страны. Административный центр — город Раквере. ";
                    }
                    else if (picker.SelectedIndex == 6)
                    {
                        img.Source = "laanemaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ляэнемаа  — уезд в Эстонии, расположенный на крайнем западе материковой части страны. С севера и запада омывается Балтийским морем. Граничит с уездами Харьюмаа на северо-востоке, Рапламаа на востоке и Пярнумаа на юге. Административный центр — город Хаапсалу. Уезд в административном отношении делится на 1 город и 9 волостей.";
                    }
                    else if (picker.SelectedIndex == 7)
                    {
                        img.Source = "põlva.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Пы́лвамаа  — уезд на юго-востоке Эстонии. Граничит с Россией на востоке, а также с уездами Вырумаа, Валгамаа и Тартумаа. Административный центр — город Пылва. До административной реформы местных самоуправлений Эстонии 2017 года уезд делился на 13 волостей, после — на 3 волости";
                    }
                    else if (picker.SelectedIndex == 8)
                    {
                        img.Source = "pärnu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Пярнумаа — самый крупный по площади уезд в Эстонии, расположенный в юго-западной части страны на побережье Рижского залива. Граничит с уездами Ляэнемаа и Рапламаа на севере и Ярвамаа и Вильяндимаа на востоке. Административный центр — город Пярну. Уезд в административном отношении делится на 2 города и 17 волостей.";
                    }
                    else if (picker.SelectedIndex == 9)
                    {
                        img.Source = "rapla.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Рапламаа  — уезд в Эстонии, расположенный в западной части страны. Граничит с уездами Ярвамаа на востоке, Пярнумаа на юге, Ляэнемаа на западе и Харьюмаа на севере. Административный центр — город Рапла. Уезд в административном отношении делится на 10 волостей.";
                    }
                    else if (picker.SelectedIndex == 10)
                    {
                        img.Source = "saaremaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Са́аремаа  — уезд в Эстонии, территория которого состоит из островов Сааремаа, Муху, Абрука, Вилсанди, Рухну и других более мелких островов.";
                    }
                    else if (picker.SelectedIndex == 11)
                    {
                        img.Source = "tartu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Та́ртумаа  — один из 15 уездов Эстонской Республики. Административный центр — город Тарту. ";
                    }
                    else if (picker.SelectedIndex == 12)
                    {
                        img.Source = "harju.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Харьюмаа, или Харью , — один из 15 уездов Эстонии. Административный центр — столица страны Таллин. С 21 декабря 2009 года старейшина уезда — Юлле Раясалу (Ülle Rajasalu). ";
                    }
                    else if (picker.SelectedIndex == 13)
                    {
                        img.Source = "hiiu.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Хийумаа  — уезд в Эстонии, территория которого состоит из острова Хийумаа и окружающих его малых островов. Административный центр уезда — город Кярдла. ";
                    }
                    else if (picker.SelectedIndex == 14)
                    {
                        img.Source = "jaarvamaa.png";
                        stol.Title = stol.Items[stol.SelectedIndex];
                        entry.Text = "Ярвамаа  — уезд в Эстонии, расположенный в центральной части страны. Административный центр — город Пайде. ";
                    }
                }
                {
                }
            }
        }

    }
}