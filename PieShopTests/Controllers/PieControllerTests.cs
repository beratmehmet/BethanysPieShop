using System;
using PieShopTests.Mocks;
using BethanysPieShop.Controllers;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.ViewModels;

namespace PieShopTests.Controllers
{
	public class PieControllerTests
	{
		public PieControllerTests()
		{
		}
		[Fact]
		public void List_EmptyCategory_ReturnsAllPies()
		{
			//arrange
			var mockPieRepository = RepositoryMocks.GetPieRepository();
			var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

			var pieController = new PieController(mockPieRepository.Object,mockCategoryRepository.Object);

			//act
			var result = pieController.List("");

			//assert
			var viewResult = Assert.IsType<ViewResult>(result);
			var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
			Assert.Equal(10, pieListViewModel.Pies.Count());
		}
	}
}

