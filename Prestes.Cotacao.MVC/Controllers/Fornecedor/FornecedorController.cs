﻿using System.Linq;
using System.Web.Mvc;
using Prestes.Cotacao.Application.Services;
using Prestes.Cotacao.MVC.ViewModels;

namespace Prestes.Cotacao.MVC.Controllers.Fornecedor
{
    public class FornecedorController : Controller
    {
        private readonly FornecedorAppService _fornecedorApp;
        public FornecedorController(FornecedorAppService fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_fornecedorApp.GetAll().Select(FornecedorViewModel.MapearFornecedores));
        }

       
    }
}
