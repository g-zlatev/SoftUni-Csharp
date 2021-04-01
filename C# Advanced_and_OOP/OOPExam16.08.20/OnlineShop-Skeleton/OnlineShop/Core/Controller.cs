using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private  ICollection<IComputer> computers;
        private  ICollection<IComponent> components;
        private  IComputer computer;
        private  IComponent component;

        public Controller()
        {
            this.computers = new List<IComputer>();
            this.components = new List<IComponent>();
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            if (!this.computers.Any(x => x.Id == computerId))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }

            switch (componentType)
            {
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "SolidStateDrive":
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
            }

            if (!this.components.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }

            this.components.Add(component);
            return $"Component {component.GetType().Name} with id {component.Id} added successfully in computer with id {this.computer.Id}.";
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            return "";


        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            throw new System.NotImplementedException();
        }

        public string BuyBest(decimal budget)
        {
            throw new System.NotImplementedException();
        }

        public string BuyComputer(int id)
        {
            throw new System.NotImplementedException();
        }

        public string GetComputerData(int id)
        {
            throw new System.NotImplementedException();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            throw new System.NotImplementedException();
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
