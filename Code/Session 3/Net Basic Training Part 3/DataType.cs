﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Basic_Training_Part_3
{
    public class DataType
    {
        public void SystemDefinedDataType()
        {

           

        }

        //public void UserDefinedDataType()
        //{
        //}

        public void TypeInference()
        {
            string name = "Bugs Bunny";
            int age = 25;
            bool isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine("name is type " + nameType.ToString());
            Console.WriteLine("age is type " + ageType.ToString());
            Console.WriteLine("isRabbit is type " + isRabbitType.ToString());
        }
    }



}
