using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString) 
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.ShowCategorieView += ShowCategorieView;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstace((MainView)mainView);
            ICategorieRepository repository = new CategorieRepository(sqlConnectionString);
            new CategoriePresenter(view, repository);
        }

        private void ShowCategorieView(object? sender, EventArgs e)
        {
            ICategorieView view = CategorieView.GetInstace((MainView)mainView);
            ICategorieRepository repository = new CategorieRepository(sqlConnectionString);
            new CategoriePresenter(view, repository);
        }

        private void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView view = CustomerView.GetInstace((MainView)mainView);
            ICustomerRepository repository = new CustomerRepository(sqlConnectionString);
            new CustomerPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModelView.GetInstace((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

    }
}
