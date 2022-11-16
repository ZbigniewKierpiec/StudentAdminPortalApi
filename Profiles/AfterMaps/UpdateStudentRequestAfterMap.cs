using AutoMapper;
using System;
using System.Collections.Generic;
using DataModels = StudentAdminPortal.API.DataModels;
using System.Linq;
using System.Threading.Tasks;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest , DataModels.Student>
    {
       

        public void Process(UpdateStudentRequest source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Address = new DataModels.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
            
        }
    }
}
