using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Prestes.Cotacao.Application.Services;
using Prestes.Cotacao.MVC.ViewModels;
using Prestes.Cotacao.Domain;

namespace Prestes.Cotacao.MVC.Controllers.Comprador
{
    public class CompradorController : Controller
    {
        private CompradorAppService _compradorApp;

        public CompradorController(CompradorAppService compradorAppService)
        {
            _compradorApp = compradorAppService;
        }

        public ActionResult Index()
        {
            //somente para teste

            List<CompradorViewModel> compradorViewModel = new List<CompradorViewModel>();

            foreach (var comprador in _compradorApp.GetAll())
            {
                compradorViewModel.Add(new CompradorViewModel()
               {
                   CampradorId = comprador.CampradorId,
                   Cpf = comprador.Cpf.Cpf,
                   DataCadastro = comprador.DataCadastro,
                   Email = comprador.Email.Endereco,
                   Nome = comprador.Nome,
                   Empresa = comprador.Empresa
               });
            }


            //var compradorViewModel = Mapper.Map<IEnumerable<Domain.Entities.Comprador>, IEnumerable<CompradorViewModel>>(_compradorApp.GetAll());

            return View(compradorViewModel);
        }

        // GET: Comprador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comprador/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CompradorViewModel comprador)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<CompradorViewModel, Domain.Entities.Comprador>(comprador);
                _compradorApp.Add(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(comprador);
        }

        public ActionResult Edit(int id)
        {
            var comprador = _compradorApp.GetById(id);
            var compradorViewModel = Mapper.Map<Domain.Entities.Comprador, CompradorViewModel>(comprador);

            return View(compradorViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CompradorViewModel comprador)
        {
            if (ModelState.IsValid)
            {
                var compradorDomain = Mapper.Map<CompradorViewModel, Domain.Entities.Comprador>(comprador);
                _compradorApp.Update(compradorDomain);

                return RedirectToAction("Index");
            }

            return View(comprador);
        }


        public ActionResult Delete(int id)
        {
            var comprador = _compradorApp.GetById(id);
            var compradorViewModel = Mapper.Map<Domain.Entities.Comprador, CompradorViewModel>(comprador);

            return View(compradorViewModel);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _compradorApp.GetById(id);
            _compradorApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
