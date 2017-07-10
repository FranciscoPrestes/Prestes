using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Prestes.Cotacao.Application.Services;
using Prestes.Cotacao.MVC.ViewModels;

namespace Prestes.Cotacao.MVC.Controllers.Comprador
{
    public class CompradorController : Controller
    {
        private CompradorAppService _compradorApp;
        private EmpresaAppService _empresaApp;

        public CompradorController(CompradorAppService compradorAppService, EmpresaAppService empresaAppService)
        {
            _compradorApp = compradorAppService;
            _empresaApp = empresaAppService;
        }

        public ActionResult Index()
        {
            //decidi fazer meu mapeamento para ter mais eficiencia nos objetos complexos
            //var compradorViewModel = Mapper.Map<IEnumerable<Domain.Entities.Comprador>, IEnumerable<CompradorViewModel>>(_compradorApp.GetAll());

            return View(CompradorViewModel.ModelToViewModel(_compradorApp.GetAll()));
        }


        public ActionResult Details(int id)
        {
            var compradorViewModel = CompradorViewModel.ModelToViewModel(_compradorApp.GetBy(id));

            return View(compradorViewModel);
        }


        public ActionResult Create()
        {
            return View("Form",CompradorViewModel.ModelToViewModel(new Domain.Entities.Comprador(), _empresaApp));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Gravar(CompradorViewModel comprador)
        {
            if (ModelState.IsValid)
            {
                //var compradorDomain = Mapper.Map<CompradorViewModel, Domain.Entities.Comprador>(comprador);
                var compradorDomain = CompradorViewModel.ViewModelToModel(comprador);

                if (0 == comprador.CampradorId)
                {
                    _compradorApp.Add(compradorDomain);
                }
                else
                {
                    _compradorApp.Update(compradorDomain);
                }

                return RedirectToAction("Index");
            }

            return View("Form",comprador);
        }

        public ActionResult Edit(int id)
        {
            var comprador = _compradorApp.GetBy(id);
            //Mapper.Map<Domain.Entities.Comprador, CompradorViewModel>(comprador);

            var compradorViewModel = CompradorViewModel.ModelToViewModel(_compradorApp.GetBy(id), _empresaApp);

            return View("Form",compradorViewModel);
        }


       
        public ActionResult Delete(int id)
        {
            var comprador = _compradorApp.GetBy(id);
            var compradorViewModel = CompradorViewModel.ModelToViewModel(_compradorApp.GetBy(id)); //Mapper.Map<Domain.Entities.Comprador, CompradorViewModel>(comprador);

            return View(compradorViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var comprador = _compradorApp.GetBy(id);
            _compradorApp.Remove(comprador);

            return RedirectToAction("Index");
        }
    }
}
