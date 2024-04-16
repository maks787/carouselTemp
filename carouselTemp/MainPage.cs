using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace carouselTemp
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            List<(string, string, string, string,int)> lehed = new List<(string, string, string, string,int)>()
            {
                ("Koleeriline", "https://testograd.com/test/test-na-kholerika-sangvinika-flegmatika-melankholika/", "~/carouselTemp.Android/Resources/drawable/Koleeriline.PNG", "Koleerilise temperamendiga inimest võib iseloomustada kui kiiret, tormilist, kes suudab end kirglikult asjale pühenduda, ületada olulisi raskusi, kuid samas on tasakaalustamata, kalduv vägivaldseteks emotsionaalseteks purseteks ja äkilisteks meeleolumuutusteks[1][2][4]. Seda temperamenti iseloomustavad tugevad, kiiresti esilekerkivad tunded, mis kajastuvad elavalt kõnes, žestides ja näoilmetes",1),
                ("Flegmaatiline", "https://testograd.com/test/test-na-kholerika-sangvinika-flegmatika-melankholika/", "~/carouselTemp.Android/Resources/drawable/Flegmatik.PNG", "Flegmaatilise temperamendiga inimest võib iseloomustada kui aeglast, rahulikku, stabiilsete püüdluste ja enam-vähem püsiva meeleoluga inimest, kelle vaimse seisundi väline väljendus on nõrk[3]. Flegmaatikut iseloomustab tugev, tasakaalustatud, inertset tüüpi närvisüsteem[1]. Sellistel inimestel on usaldusväärne mälu ja nad kipuvad tegema läbimõeldud, tasakaalustatud ja mitte riskantseid otsuseid",2),
                ("Melanhoolne", "https://testograd.com/test/test-na-kholerika-sangvinika-flegmatika-melankholika/", "~/carouselTemp.Android/Resources/drawable/Melonholik.PNG", "Melanhoolikku iseloomu võib määrata kalduvus depressiivsetele seisunditele. Temperament melanhoolne põhjustab selliste omaduste olemasolu nagu eemaletõmbumine, isoleeritus, suurenenud emotsionaalsus, tundlikkus, mõjutatavus. Melanhoolikute puhul esineb afektiivseid häireid ja ärevushäireid palju rohkem kui teiste temperamenditüüpide esindajate puhul.",3),
                ("Sanguline", "https://testograd.com/test/test-na-kholerika-sangvinika-flegmatika-melankholika/", "~/carouselTemp.Android/Resources/drawable/Sangviinne.PNG", "Sangviinne on isiksus, keda iseloomustab suur vaimne aktiivsus, elujõud, tõhusus, liigutuste kiirus ja elavus, näoilmete mitmekesisus ja rikkalikkus, kiire kõnetempo[4][5]. Sangviinidel on kalduvus sagedasele muljete muutumisele, nad reageerivad kergesti ja kiiresti ümbritsevatele sündmustele, on seltskondlikud[4][5]. Sangviini emotsioonid on valdavalt positiivsed, tekivad kiiresti ja muutuvad kiiresti[4][5]. Ta kohaneb kiiresti uute tingimustega ja saab kiiresti inimestega läbi[3]. Tema tunded tekivad kergesti ja asenduvad uutega, teda iseloomustab väljendusrikkus, kuid mõnikord ka tujukus[3]. ",4),
                ("Marina Oleinik", "https://testograd.com/test/test-na-kholerika-sangvinika-flegmatika-melankholika/", "~/carouselTemp.Android/Resources/drawable/aaa.PNG", "Sangviinne on isiksus, keda iseloomustab suur vaimne aktiivsus, elujõud, tõhusus, liigutuste kiirus ja elavus, näoilmete mitmekesisus ja rikkalikkus, kiire kõnetempo[4][5]. Sangviinidel on kalduvus sagedasele muljete muutumisele, nad reageerivad kergesti ja kiiresti ümbritsevatele sündmustele, on seltskondlikud[4][5]. Sangviini emotsioonid on valdavalt positiivsed, tekivad kiiresti ja muutuvad kiiresti[4][5]. Ta kohaneb kiiresti uute tingimustega ja saab kiiresti inimestega läbi[3]. Tema tunded tekivad kergesti ja asenduvad uutega, teda iseloomustab väljendusrikkus, kuid mõnikord ka tujukus[3]. ",5)

            };

            foreach (var lehtinfo in lehed)
            {
                uusleht(lehtinfo.Item1, lehtinfo.Item2, lehtinfo.Item3, lehtinfo.Item4,lehtinfo.Item5);
            }
        }

        public void uusleht(string name, string url, string img, string text, int lehednum)
        {
            Button siteBtn = new Button
            {
                Text = "Test",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            };
            siteBtn.Clicked += async (sender, e) =>
                await Browser.OpenAsync(url);

            Label Lbl = new Label
            {
                Text = name,
                HorizontalOptions = LayoutOptions.Center
            };
            ImageButton ImgBtn = new ImageButton
            {
                Source = img,
                HeightRequest = 400,
                WidthRequest = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            ImgBtn.Clicked += async (sender, e) =>
                await DisplayAlert(name, text, "Sule");
            Label lbl2 = new Label
            {
                Text = lehednum.ToString(),

            };
            var Page = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        Lbl, ImgBtn, siteBtn,lbl2
                    }
                }
            };
            Children.Add(Page);
        }
    }
}
