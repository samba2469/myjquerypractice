﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sivaEntities : DbContext
    {
        public sivaEntities()
            : base("name=sivaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<register> registers { get; set; }
    
        public virtual ObjectResult<Diplay_All_Result> Diplay_All()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Diplay_All_Result>("Diplay_All");
        }
    
        public virtual int register_Insert(Nullable<int> id, string name, string password, string email, Nullable<long> phno, Nullable<System.DateTime> dateofbirth, string gender, string language, string address)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var phnoParameter = phno.HasValue ?
                new ObjectParameter("phno", phno) :
                new ObjectParameter("phno", typeof(long));
    
            var dateofbirthParameter = dateofbirth.HasValue ?
                new ObjectParameter("dateofbirth", dateofbirth) :
                new ObjectParameter("dateofbirth", typeof(System.DateTime));
    
            var genderParameter = gender != null ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(string));
    
            var languageParameter = language != null ?
                new ObjectParameter("language", language) :
                new ObjectParameter("language", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("register_Insert", idParameter, nameParameter, passwordParameter, emailParameter, phnoParameter, dateofbirthParameter, genderParameter, languageParameter, addressParameter);
        }
    }
}