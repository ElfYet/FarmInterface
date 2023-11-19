using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public class Testing
    {

        public static void PopulateBarnTest(ItemContainer rootContainer)
        {
            var barn = new ItemContainer { Name = "Barn" };
            rootContainer.AddItem(barn);

            var livestockArea = new ItemContainer { Name = "Livestock-Area" };
            barn.AddItem(livestockArea);

            var cow = new Item { Name = "Cow" };
            livestockArea.AddItem(cow);

            var milkstorage = new Item { Name = "Milk Storage" };
            barn.AddItem(milkstorage);

            var storageBuilding = new ItemContainer { Name = "Storage Building" };
            rootContainer.AddItem(storageBuilding);

            var tractor = new Item { Name = "Tractor" };
            storageBuilding.AddItem(tractor);

            var tiller = new Item { Name = "Tiller" };
            storageBuilding.AddItem(tiller);

            var commandCenter = new ItemContainer { Name = "Command Center" };
            rootContainer.AddItem(commandCenter);

            var drone = new Item { Name = "Drone" };
            commandCenter.AddItem(drone);

            var soyCrop = new Item { Name = "Soy Crop" };
            rootContainer.AddItem(soyCrop);
        }
    }
}
