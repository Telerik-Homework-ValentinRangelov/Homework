using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Cars.Tests.JustMock.Mocks
{
    using System.Linq;

    using Cars.Contracts;
    using Cars.Models;

    using Telerik.JustMock;

    public class JustMockCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            this.CarsData = Mock.Create<ICarsRepository>();
            Mock.Arrange(() => this.CarsData.Add(Arg.IsAny<Car>())).DoNothing();
            Mock.Arrange(() => this.CarsData.All()).Returns(this.FakeCarCollection);
            Mock.Arrange(() => this.CarsData.Search(Arg.AnyString))
                .Returns((string search) =>
                    this.FakeCarCollection
                            .Where(c => c.Make.ToLower() == search.ToLower() ||
                                    c.Model.ToLower() == search.ToLower())
                            .ToList());
            Mock.Arrange(() => this.CarsData.Search(Arg.NullOrEmpty))
                .Returns(this.FakeCarCollection.ToList());

            Mock.Arrange(() => this.CarsData.GetById(Arg.AnyInt)).Returns((int id) => this.FakeCarCollection.First());
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange(0, this.FakeCarCollection.Count, RangeKind.Exclusive))).Returns((int id) => this.FakeCarCollection.First(car => car.Id == id));
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange(Int32.MinValue, 0, RangeKind.Inclusive))).DoNothing();

            Mock.Arrange(() => this.CarsData.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            Mock.Arrange(() => this.CarsData.SortedByYear()).Returns(this.FakeCarCollection.OrderBy(c => c.Year).ToList());
        }
    }
}
