﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Persistance;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class AdultService : IAdultService
    {
        private FileContext fileContext;

        public AdultService()
        {
            fileContext = new FileContext();
        }

        public IList<Adult> GetAdults()
        {
            IList<Adult> adults = fileContext.Adults;
            return adults;
        }

        public void AddAdult(Adult newAdult)
        {
            newAdult.Id = fileContext.Adults.ElementAt(fileContext.Adults.Count - 1).Id + 1;
            fileContext.Adults.Add(newAdult);
            fileContext.SaveChanges();
        }

        public void UpdateAdultInfo(Adult newAdult)
        {
            // update adult info method
            Adult adult = fileContext.Adults.First(a => a.Id == newAdult.Id);
            int indexAt = fileContext.Adults.IndexOf(adult);
            adult.Update(newAdult);
            //update adult list
            fileContext.Adults.RemoveAt(indexAt);
            fileContext.Adults.Insert(indexAt,adult);
            fileContext.SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            int idToFind = adult.Id;
            int position = -1;
            for (int i=0; i<fileContext.Adults.Count;i++)
            {
                if (fileContext.Adults.ElementAt(i).Id == idToFind)
                    position = i;
            }

            if (position != -1)
            {
                fileContext.Adults.RemoveAt(position);
                fileContext.SaveChanges();
            }
        }
    }
}