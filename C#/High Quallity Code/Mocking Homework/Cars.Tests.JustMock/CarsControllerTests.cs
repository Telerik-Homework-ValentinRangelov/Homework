namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        //Since Moq does not have It.IsNotNullOrEmpty the outcome may be different
        //: this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SearchShouldWorkPropperlyWithMake()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("Audi"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(2, cars.Count);

            foreach (var car in cars)
            {
                Assert.AreEqual("Audi", car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldWorkPropperlyWithModel()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("Astra"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(1, cars.Count);
            foreach (var car in cars)
            {
                Assert.AreEqual("Opel", car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldReturnWholeListWhenEmptyInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search(""));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);
        }

        [TestMethod]
        public void SearchShouldReturnWholeListWhenNullInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search(null));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);
        }

        [TestMethod]
        public void SearchShouldReturnNothingWhenBadInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("pesho"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(0, cars.Count);
        }

        [TestMethod]
        public void DetailShouldWorkCorrectlyWhenProvidedValidId()
        {
            var detailsForCar = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual(1, detailsForCar.Id);
            Assert.AreEqual("Audi", detailsForCar.Make);
            Assert.AreEqual(2005, detailsForCar.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailShouldThrowWhenArgumentNullExceptionProvidedInvalidInput()
        {
            var detailsForCar = (Car)this.GetModel(() => this.controller.Details(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortByMakeShouldThrowArgumentExceptionWhenEmptyInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort(" "));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortByMakeShouldThrowArgumentExceptionWhenNullInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortByMakeShouldThrowArgumentExceptionWhenWrongInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("model"));
        }

        [TestMethod]
        public void SortByMakeShouldWorkCorrectly()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);

            Assert.AreEqual("Audi", cars[0].Make);
            Assert.AreEqual("Audi", cars[1].Make);
            Assert.AreEqual("BMW", cars[2].Make);
            Assert.AreEqual("Opel", cars[3].Make);
        }

        [TestMethod]
        public void SortByYearShouldWorkCorrectly()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);

            Assert.AreEqual(2005, cars[0].Year);
            Assert.AreEqual(2007, cars[1].Year);
            Assert.AreEqual(2008, cars[2].Year);
            Assert.AreEqual(2010, cars[3].Year);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }

    }
}
