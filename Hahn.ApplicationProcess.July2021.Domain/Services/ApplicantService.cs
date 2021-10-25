using Hahn.ApplicationProcess.July2021.Core;
using Hahn.ApplicationProcess.July2021.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hahn.ApplicationProcess.July2021.Domain.Services
{
    public class ApplicantService : IApplicantService
    {
        private DbSet<Applicant> db;
        private readonly ApplicantContext ctx;
        public ApplicantService(ApplicantContext context)
        {
            db = context.Applicants;
            ctx = context;
        }

        public bool Delete(Applicant Item)
        {
            db.Remove(Item);
            ctx.SaveChanges();
            return true;
        }

        public Applicant Find(int Id)
        {
            return db.Where(x => x.ID == Id).FirstOrDefault(); 
        }

        public List<Applicant> GetAll()
        {
            return db.ToList(); 
        }

        public Applicant Save(Applicant item)
        {
            db.Add(item);
            ctx.SaveChanges();
            return db.Last();
        }

        public Applicant Update(Applicant item)
        {
            var currItem = db.Find(item.ID);
            if (currItem == null) { return null; }
            db.Update(currItem);
            ctx.SaveChanges();
            return currItem; 
        }
    }
}
