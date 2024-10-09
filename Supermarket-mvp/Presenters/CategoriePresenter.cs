using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Presenters
{
    internal class CategoriePresenter
    {
        private ICategorieView view;
        private ICategorieRepository repository;
        private BindingSource categorieBindingSource;
        private IEnumerable<CategorieModel> categorieList;

        public CategoriePresenter(ICategorieView view, ICategorieRepository repository)
        {
            this.categorieBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategorie;
            this.view.AddNewEvent += AddNewCategorie;
            this.view.EditEvent += LoadSelectCategorieToEdit;
            this.view.DeleteEvent += DeleteSelectedCategorie;
            this.view.SaveEvent += SaveCategorie;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategorieListBildingSource(categorieBindingSource);

            LoadAllPayModeList();

            this.view.Show();
        }

        private void LoadAllPayModeList()
        {
            categorieList = repository.GetAll();
            categorieBindingSource.DataSource = categorieList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.CategorieId = "";
            view.CategorieName = "";
            view.CategorieDescription = "";
        }

        private void SaveCategorie(object? sender, EventArgs e)
        {
            var categorie = new CategorieModel();
            categorie.Id = Convert.ToInt32(view.CategorieId);
            categorie.Name = view.CategorieName;
            categorie.Description = view.CategorieDescription;

            try
            {
                new Common.ModelDataValidation().Validate(categorie);
                if (view.IsEdit)
                {
                    repository.Edit(categorie);
                    view.Message = "Categorie Edit Successfuly";
                }
                else
                {
                    repository.Add(categorie);
                    view.Message = "Categorie added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllPayModeList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCategorie(object? sender, EventArgs e)
        {
            try
            {
                var categorie = (CategorieModel)categorieBindingSource.Current;
                repository.Delete(categorie.Id);
                view.IsSuccessful = true;
                view.Message = "Categorie deleted Successfuly";
                LoadAllPayModeList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete categorie";
            }
        }

        private void LoadSelectCategorieToEdit(object? sender, EventArgs e)
        {
            var categorie = (CategorieModel)categorieBindingSource.Current;

            view.CategorieId = categorie.Id.ToString();
            view.CategorieName = categorie.Name;
            view.CategorieDescription = categorie.Description;

            view.IsEdit = true;
        }

        private void AddNewCategorie(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategorie(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorieList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorieList = repository.GetAll();
            }
            categorieBindingSource.DataSource = categorieList;
        }
    }
}
