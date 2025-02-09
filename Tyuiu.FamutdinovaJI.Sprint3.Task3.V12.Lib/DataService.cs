﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FamutdinovaJI.Sprint3.Task3.V12.Lib
{
    public class DataService : ISprint3Task3V12
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int max = -1;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }    
                
            }
            return max;
        }
    }
}
