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

            serviceList.Add(new ServiceMaster() { ServiceType = "Paraffin Hand Treatment", ServiceDesc = "Paraffin treatment" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Paraffin Foot Treatment", ServiceDesc = "Paraffin treatment" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Gel Overlays", ServiceDesc = "Gel nails" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Acrylic Overlays", ServiceDesc = "Acrylic Nails" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Infills", ServiceDesc = "Nail Infills" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Soak off", ServiceDesc = "Nail Soak off" });
            serviceList.Add(new ServiceMaster() { ServiceType = "French Infill", ServiceDesc = "Pink/White or any colors Infills" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Valvet NailArt", ServiceDesc = "Nail Art Valvet" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Cavier NailArt", ServiceDesc = "Cavier Nail Art" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Crackle NailArt", ServiceDesc = "Crackle Nail Art" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Neon NailArt", ServiceDesc = "Nailart neon" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Glitter NailArt", ServiceDesc = "Nailart-glitter" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Mountain NailArt", ServiceDesc = "Nailart-mountain" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Beads NailArt", ServiceDesc = "Nailart-beads" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Wedding NailArt", ServiceDesc = "Nailart-wedding" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Manicure (Basic)", ServiceDesc = "BasicManicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "French Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Reverse French Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Hotstone Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "American Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Gel Manicure", ServiceDesc = "Manicure" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Nail Overlays Regular", ServiceDesc = "Overlays" });
            serviceList.Add(new ServiceMaster() { ServiceType = "Pedicure", ServiceDesc = "Pedicure" });

            foreach (ServiceMaster ser in serviceList)
                context.ServiceMasters.Add(ser);

            //default data for Service Price List
            List<ServicePrice> servicePriceList = new List<ServicePrice>();
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£10" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£15" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£20" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£22" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£25" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£27" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£30" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£45" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£46" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£64" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£120" });
            servicePriceList.Add(new ServicePrice() { ServicePrice1 = "£250" });
            foreach (ServicePrice SPL in servicePriceList)
                context.ServicePrices.Add(SPL);

            //DETAILS OF SLOT
            List<Slot> slots = new List<Slot>();
            slots.Add(new Slot() { SlotType = "Morning : 09:00AM-10:00AM" });
            slots.Add(new Slot() { SlotType = "Morning : 10:00AM-11:00AM" });
            slots.Add(new Slot() { SlotType = "Morning : 11:00AM-12:00AM" });
            slots.Add(new Slot() { SlotType = "Afternoon : 12:00PM-01:00PM" });
            slots.Add(new Slot() { SlotType = "Afternoon : 01:00PM-02:00PM" });
            slots.Add(new Slot() { SlotType = "Afternoon : 02:00PM-03:00PM" });
            slots.Add(new Slot() { SlotType = "Afternoon : 03:00PM-04:00PM" });
            slots.Add(new Slot() { SlotType = "Evening : 04:00PM-05:00PM" });
            slots.Add(new Slot() { SlotType = "Evening : 05:00PM-06:00PM" });
            slots.Add(new Slot() { SlotType = "Evening : 06:00PM-7:00PM" });
            slots.Add(new Slot() { SlotType = "Evening : 07:00PM-8:00PM" });
            slots.Add(new Slot() { SlotType = "Evening : 08:00PM-9:00PM" });
            foreach (Slot SL in slots)
                context.Slots.Add(SL);

            //DETAILS OF serviceDuration
            List<ServiceDuration> serviceDurationList = new List<ServiceDuration>();
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "120mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "85mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "60mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "55mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "45mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "25mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "20mins" });
            serviceDurationList.Add(new ServiceDuration() { ServiceDuration1 = "15mins" });
            foreach (ServiceDuration SD in serviceDurationList)
                context.ServiceDurations.Add(SD);

            //Details Of ServiceVariation
            List<ServiceVeriation> serviceVariationList = new List<ServiceVeriation>();
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Regular" });
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Luxury" });
            serviceVariationList.Add(new ServiceVeriation() { ServiceVariation = "Express" });
            foreach (ServiceVeriation SV in serviceVariationList)
                context.ServiceVeriations.Add(SV);

            List<ServiceBillDesk> serviceBillDeskList = new List<ServiceBillDesk>();
            foreach (var item in serviceList)
            {
                serviceBillDeskList.Add(new ServiceBillDesk()
                {
                    ServiceID = item.ID,
                    //ServicePriceID=

                });
                serviceBillDeskList.Add(new ServiceBillDesk()
                {
                    ServiceID = item.ID,


                });
                serviceBillDeskList.Add(new ServiceBillDesk()
                {
                    ServiceID = item.ID,


                });



                base.Seed(context);
            }
        }


    }
}