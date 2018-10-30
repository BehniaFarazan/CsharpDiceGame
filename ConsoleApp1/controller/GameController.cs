using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.entity;

namespace ConsoleApp1.controller
{
    class GameController
    {

        static GameController()
        {
            InputValidator inputValidator = new InputValidator();
            Logic logic = new Logic();
        }

    }
}
