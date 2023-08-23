using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Clovece;
using CloveceWeb.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloveceWeb.Controllers
{
    public class CloveceController : Controller
    {

        CloveceModel cloveceModel;
        Vypocty vypocty = new Vypocty();
        Kocka kocka = new Kocka();

        public IActionResult Index()
        {
            cloveceModel = new CloveceModel();
            cloveceModel.data = new Data.GameData();
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);

            return View(cloveceModel);
        }

        public IActionResult UrobAkciu()
        {
            //1 - nacitaj
            cloveceModel = GetDataFromSession();

            //urob akcie
            cloveceModel.Hodnota++;

            //uloz
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);

            Debug.WriteLine("Akcia :  UrobAkciu");
            return View("Index",cloveceModel);
        }

        public IActionResult UrobSuperAkciu(int jahoda, string medved)
        {
            cloveceModel = GetDataFromSession();
            //zavolaj logiku

            cloveceModel.Message = medved;
            Debug.WriteLine("Akcia :  UrobAkciu - jahoda: "+jahoda+"   medved: "+medved);
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);
            return View("Index",cloveceModel);
        }

        public IActionResult NakresliMapu()
        {
            //1 - nacitaj
            cloveceModel = GetDataFromSession();

            //urob akcie

            //uloz
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);
            return View("Mapa", cloveceModel);
        }

        public IActionResult ZadajPocet(int pocet)
        {
            //1 - nacitaj
            cloveceModel = GetDataFromSession();

            //urob akcie
            cloveceModel.Pocet = pocet;
            cloveceModel.data.farbaHraca = new string[pocet];
            cloveceModel.data.Farba = new string[16];
            cloveceModel.data.Hrac_x = new int[16];
            cloveceModel.data.Hrac_y = new int[16];
            cloveceModel.data.Pozicia = new int[16];
            //uloz
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);
            return View("PriradFarby", cloveceModel);
        }

        public IActionResult Zacni(string farba)
        {
            //1 - nacitaj
            cloveceModel = GetDataFromSession();

            int premenna = 0;

            if(premenna < cloveceModel.PocitadloLudi)
            {
                premenna = cloveceModel.PocitadloLudi;
            }

            //urob akcie
            cloveceModel.data.farbaHraca[premenna] = farba;
            Player.Instance.Poradie[premenna] = farba;
            Debug.WriteLine(cloveceModel.data.farbaHraca[premenna]);
            premenna = premenna + 1;
            cloveceModel.PocitadloLudi = premenna;

            

            //uloz
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);
            if(premenna < cloveceModel.Pocet)
            {
                return View("PriradFarby", cloveceModel);
            }
            else
            {
                int j = 0;
                for (int i = 0; i < cloveceModel.Pocet; i++)
                {
                    if (cloveceModel.data.farbaHraca[i].Equals("zelena"))
                    {
                        for (j = 0; j < 4; j++)
                        {
                            cloveceModel.data.Farba[j] = cloveceModel.data.farbaHraca[i];
                            cloveceModel.data.Hrac_x[j] = Player.Instance.dx(cloveceModel.data.farbaHraca[i], j);
                            cloveceModel.data.Hrac_y[j] = Player.Instance.dy(cloveceModel.data.farbaHraca[i], j);
                        }
                        j = 0;
                        cloveceModel.data.Hrac_x[j] = Player.Instance.x(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                        cloveceModel.data.Hrac_y[j] = Player.Instance.y(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                    }

                    else if (cloveceModel.data.farbaHraca[i].Equals("cervena"))
                    {
                        for (j = 4; j < 8; j++)
                        {
                            cloveceModel.data.Farba[j] = cloveceModel.data.farbaHraca[i];
                            cloveceModel.data.Hrac_x[j] = Player.Instance.dx(cloveceModel.data.farbaHraca[i], j);
                            cloveceModel.data.Hrac_y[j] = Player.Instance.dy(cloveceModel.data.farbaHraca[i], j);
                        }
                        j = 4;
                        cloveceModel.data.Hrac_x[j] = Player.Instance.x(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                        cloveceModel.data.Hrac_y[j] = Player.Instance.y(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);

                    }
                    else if (cloveceModel.data.farbaHraca[i].Equals("modra"))
                    {
                        for (j = 8; j < 12; j++)
                        {
                            cloveceModel.data.Farba[j] = cloveceModel.data.farbaHraca[i];
                            cloveceModel.data.Hrac_x[j] = Player.Instance.dx(cloveceModel.data.farbaHraca[i], j);
                            cloveceModel.data.Hrac_y[j] = Player.Instance.dy(cloveceModel.data.farbaHraca[i], j);
                        }
                        j = 8;
                        cloveceModel.data.Hrac_x[j] = Player.Instance.x(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                        cloveceModel.data.Hrac_y[j] = Player.Instance.y(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                    }
                    else if (cloveceModel.data.farbaHraca[i].Equals("zlta"))
                    {
                        for (j = 12; j < 16; j++)
                        {
                            cloveceModel.data.Farba[j] = cloveceModel.data.farbaHraca[i];
                            cloveceModel.data.Hrac_x[j] = Player.Instance.dx(cloveceModel.data.farbaHraca[i], j);
                            cloveceModel.data.Hrac_y[j] = Player.Instance.dy(cloveceModel.data.farbaHraca[i], j);
                        }
                        j = 12;
                        cloveceModel.data.Hrac_x[j] = Player.Instance.x(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                        cloveceModel.data.Hrac_y[j] = Player.Instance.y(cloveceModel.data.Farba[j], cloveceModel.data.Pozicia[j]);
                    }

                }
                HttpContext.Session.SetObject("CloveceModel", cloveceModel);
                return View("Mapa", cloveceModel);
            }
        }

        public IActionResult HodKocku(string farba, int id)
        {
            //1 - nacitaj
            cloveceModel = GetDataFromSession();

            //urob akcie
            int premenna = kocka.hod();
            cloveceModel.data.Pozicia[id] += premenna;
            cloveceModel.data.Hrac_x[id] = Player.Instance.x(cloveceModel.data.Farba[id], cloveceModel.data.Pozicia[id]);
            cloveceModel.data.Hrac_y[id] = Player.Instance.y(cloveceModel.data.Farba[id], cloveceModel.data.Pozicia[id]);
            //uloz
            HttpContext.Session.SetObject("CloveceModel", cloveceModel);
            return View("Mapa", cloveceModel);
        }



        public IActionResult Vyhraj()
        {
            return View("Winner");
        }

        private CloveceModel GetDataFromSession()
        {
            return (CloveceModel)HttpContext.Session.GetObject("CloveceModel");
        }

    }
}