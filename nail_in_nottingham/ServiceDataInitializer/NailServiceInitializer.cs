using nail_in_nottingham.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace nail_in_nottingham.ServiceDataInitializer
{
    public class NailServiceInitializer : DropCreateDatabaseIfModelChanges<NailModel>
    {
        protected override void Seed(NailModel context)
        {
            //defaul data for ServiceList
            List<ServiceMaster> serviceList = new List<ServiceMaster>();
            serviceList.Add(new ServiceMaster() { ServiceType = "Velvet NailArt", ServiceDesc = "Nail Art Valvet" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Cavier NailArt", ServiceDesc = "Cavier Nail Art" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Neon NailArt", ServiceDesc = "Nailart neon" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Crackle NailArt", ServiceDesc = "Crackle Nail Art" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Glitter NailArt", ServiceDesc = "Nailart-glitter" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Beads NailArt", ServiceDesc = "Nailart-beads" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Wedding NailArt", ServiceDesc = "Nailart-wedding" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Mountain NailArt", ServiceDesc = "Nailart-mountain" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Soak off", ServiceDesc = "Nail Soak off" });

            serviceList.Add(new ServiceMaster() { ServiceType = "Nail Overlays Regular", ServiceDesc = "Overlays" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Gel Overlays", ServiceDesc = "Gel nails" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Acrylic Overlays", ServiceDesc = "Acrylic Nails" });

            serviceList.Add(new ServiceMaster() { ServiceType = "Infills", ServiceDesc = "Nail Infills" });
            serviceList.Add(new ServiceMaster() { ServiceType = "French Infill", ServiceDesc = "Pink/White or any colors Infills" });

            serviceList.Add(new ServiceMaster() { ServiceType = "Manicure Basic", ServiceDesc = "BasicManicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "French Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Reverse French Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "American Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Gel Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Hotstone Manicure", ServiceDesc = "Manicure" });


            serviceList.Add(new ServiceMaster() { ServiceType = "Pedicure", ServiceDesc = "Pedicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Manicure And Pedicure", ServiceDesc = "ManicureandPedicure" });


            serviceList.Add(new ServiceMaster() { ServiceType = "Paraffin Hand Treatment", ServiceDesc = "Paraffin treatment" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Paraffin Foot Treatment", ServiceDesc = "Paraffin treatment" });

            serviceList.Add(new ServiceMaster() { ServiceType = "Paraffin Hand And Foot Treatment", ServiceDesc = "Paraffin Hand And Foot Treatment" });

            foreach (ServiceMaster ser in serviceList)
                context.ServiceMasters.Add(ser);



            //Details Of ServiceVariation
            List<ServiceVeriation> serviceVariationList = new List<ServiceVeriation>();
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Regular" });
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Luxury" });
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Express" });
            foreach (ServiceVeriation SV in serviceVariationList)
                context.ServiceVeriations.Add(SV);
            context.SaveChanges();


            List<ServiceBillDesk> serviceBillDeskList = new List<ServiceBillDesk>();
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 1, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 1, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 1, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 2, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 2, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 2, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 3, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 3, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 3, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 4, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 4, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 4, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 5, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 5, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 5, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 6, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 6, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 6, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 7, ServiceDuration = "30", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 7, ServiceDuration = "40", ServicePrice = "60", ServiceVeriationID = 2, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 7, ServiceDuration = "20", ServicePrice = "70", ServiceVeriationID = 3, ServiceAmount = "£70", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 8, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 8, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 8, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 9, ServiceDuration = "20", ServicePrice = "20", ServiceVeriationID = 1, ServiceAmount = "£20", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 9, ServiceDuration = "30", ServicePrice = "30", ServiceVeriationID = 2, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 9, ServiceDuration = "15", ServicePrice = "45", ServiceVeriationID = 3, ServiceAmount = "£45", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 10, ServiceDuration = "20", ServicePrice = "30", ServiceVeriationID = 1, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 10, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 2, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 10, ServiceDuration = "15", ServicePrice = "50", ServiceVeriationID = 3, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 11, ServiceDuration = "20", ServicePrice = "30", ServiceVeriationID = 1, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 11, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 2, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 11, ServiceDuration = "15", ServicePrice = "50", ServiceVeriationID = 3, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "20", ServicePrice = "30", ServiceVeriationID = 1, ServiceAmount = "£30", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 2, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "15", ServicePrice = "50", ServiceVeriationID = 3, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "30", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "20", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "40", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "50", ServicePrice = "60", ServiceVeriationID = 2, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "30", ServicePrice = "70", ServiceVeriationID = 3, ServiceAmount = "£70", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "30", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "40", ServicePrice = "60", ServiceVeriationID = 2, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "20", ServicePrice = "70", ServiceVeriationID = 3, ServiceAmount = "£70", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "50", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "60", ServicePrice = "80", ServiceVeriationID = 2, ServiceAmount = "£80", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "40", ServicePrice = "90", ServiceVeriationID = 3, ServiceAmount = "£90", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "20", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "30", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "15", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "30", ServicePrice = "55", ServiceVeriationID = 1, ServiceAmount = "£55", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "40", ServicePrice = "65", ServiceVeriationID = 2, ServiceAmount = "£65", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "20", ServicePrice = "75", ServiceVeriationID = 3, ServiceAmount = "£75", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "50", ServicePrice = "70", ServiceVeriationID = 1, ServiceAmount = "£70", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "60", ServicePrice = "90", ServiceVeriationID = 2, ServiceAmount = "£90", ServiceQuantity = 1 });
            serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "80", ServicePrice = "120", ServiceVeriationID = 3, ServiceAmount = "£120", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 11, ServiceDuration = "15mins", ServicePrice = "50", ServiceVeriationID = 3, ServiceAmount = "£30", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "20mins", ServicePrice = "30", ServiceVeriationID = 1, ServiceAmount = "£30", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 2, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 12, ServiceDuration = "15mins", ServicePrice = "50", ServiceVeriationID = 3, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 13, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 14, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 15, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 16, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 17, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 18, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "30mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 19, ServiceDuration = "20mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "40mins", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "50mins", ServicePrice = "60", ServiceVeriationID = 2, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 20, ServiceDuration = "30mins", ServicePrice = "70", ServiceVeriationID = 3, ServiceAmount = "£70", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "30mins", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "40mins", ServicePrice = "60", ServiceVeriationID = 2, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 21, ServiceDuration = "20mins", ServicePrice = "70", ServiceVeriationID = 3, ServiceAmount = "£70", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "50mins", ServicePrice = "50", ServiceVeriationID = 1, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "60mins", ServicePrice = "80", ServiceVeriationID = 2, ServiceAmount = "£80", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 22, ServiceDuration = "40mins", ServicePrice = "90", ServiceVeriationID = 3, ServiceAmount = "£90", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "20mins", ServicePrice = "40", ServiceVeriationID = 1, ServiceAmount = "£40", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "30mins", ServicePrice = "50", ServiceVeriationID = 2, ServiceAmount = "£50", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 23, ServiceDuration = "15mins", ServicePrice = "60", ServiceVeriationID = 3, ServiceAmount = "£60", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "30mins", ServicePrice = "55", ServiceVeriationID = 1, ServiceAmount = "£55", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "40mins", ServicePrice = "65", ServiceVeriationID = 2, ServiceAmount = "£65", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 24, ServiceDuration = "20mins", ServicePrice = "75", ServiceVeriationID = 3, ServiceAmount = "£75", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "50mins", ServicePrice = "70", ServiceVeriationID = 1, ServiceAmount = "£70", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "60mins", ServicePrice = "90", ServiceVeriationID = 2, ServiceAmount = "£90", ServiceQuantity = 1 });
            //serviceBillDeskList.Add(new ServiceBillDesk() { ServiceID = 25, ServiceDuration = "80mins", ServicePrice = "120", ServiceVeriationID = 3, ServiceAmount = "£120", ServiceQuantity = 1 });



            foreach (ServiceBillDesk SBD in serviceBillDeskList)
                context.ServiceBillDesks.Add(SBD);

            base.Seed(context);
            }

    }


    }

