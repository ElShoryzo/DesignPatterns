﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal interface IPizzaBuilder
    {
        void AddCheese();
        void AddPepperoni();
        void AddHam();
        void AddMushrooms();
        void AddPineapple();
        void AddOnions();
        void AddPeppers();
        void AddSausage();
        void AddSpinach();
        void AddTomato();
        void AddOlives();
        void AddBacon();
        void AddChicken();
        void AddBeef();
        void AddPork();
        void AddShrimp();
        void AddLobster();
        void AddCrab();
        void AddAnchovies();
        void AddTuna();
        void AddSalmon();
        void AddTrout();
        void AddMackerel();
        void AddSardines();
        void AddHerring();
        void AddCaviar();
        void AddEgg();
        void AddTofu();
        void AddSeitan();
        void AddTempeh();
        void AddAvocado();
        void AddArtichoke();
        void AddAsparagus();
        void AddBroccoli();
        void AddCauliflower();
        void AddCorn();
        void AddCucumber();
        void AddEggplant();
        void AddGreenBeans();
        void AddKale();
        void AddLeeks();
        void AddLettuce();
        void AddPotato();
        void AddPumpkin();
        void AddRadish();
        void AddSquash();
        void AddSweetPotato();
        void AddTurnip();
        void AddZucchini();
        void AddApple();
        void AddApricot();
        void AddBanana();
        void AddBlackberry();
        void AddBlueberry();
        void AddCherry();
        void AddCoconut();
        void AddCranberry();
        void AddDate();
        void AddDragonfruit();
        void AddDurian();
        void AddFig();
        void AddGrape();
        Pizza GetPizza();
    }
}