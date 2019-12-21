using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Projeto_C_Sharp.Models;

namespace Projeto_C_Sharp.Controllers
{
    public class PacienteController : Controller
    {
        private static PacienteTeste _pacientes = new PacienteTeste();
        // GET: Paciente
        public IActionResult Index()
        {
            return View(_pacientes.listaPaciente);
        }       
        //CRIA PACIENTE
        public IActionResult AdicionaPaciente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdicionaPaciente(PacienteModel pacienteModel)
        {
            _pacientes.CriaPaciente(pacienteModel);
            return View();
        }
        //DELETA PACIENTE
        public ViewResult DeletaPaciente(string id) {
            return View(_pacientes.GetPaciente(id));
        }
        [HttpPost]
        public RedirectToActionResult DeletaPaciente(string id, IFormCollection collection) {
            _pacientes.DeletaPaciente(id);
            return RedirectToAction("Index");
        }
        //EDITA PACIENTE
        public ViewResult EditaPaciente(string id) {
            return View(_pacientes.GetPaciente(id));
        }
        [HttpPost]
        public RedirectToActionResult EditaPaciente(string Id, IFormCollection collection){
            PacienteModel p = new PacienteModel();
            p.id = collection["id"];
            p.nome = collection["nome"];
            p.sobrenome = collection["sobrenome"];
            p.nascimento = Convert.ToDateTime(collection["nascimento"]);
            p.email = collection["email"];
            p.dataConsulta = Convert.ToDateTime(collection["dataConsulta"]);
            _pacientes.AtualizaPaciente(p);
            return RedirectToAction("Index");
        }
        //DETALHE PACIENTE
        public ViewResult DetalhePaciente(string id) {
            return View(_pacientes.GetPaciente(id));
        }
        [HttpPost]
        public RedirectToRouteResult DetalhePaciente(string id, FormCollection collection){
            _pacientes.GetPaciente(id);
            return RedirectToRoute("Index");
        }
        //MARCA CONSULTA
        public ViewResult MarcaConsulta(string id) {
            return View(_pacientes.GetPaciente(id));
        }
        [HttpPost]
        public RedirectToActionResult MarcaConsulta(string Id, IFormCollection collection)
        {
            PacienteModel p = new PacienteModel();
            //p.id = collection["id"];
            //p.nome = collection["nome"];
            //p.sobrenome = collection["sobrenome"];
            //p.nascimento = Convert.ToDateTime(collection["nascimento"]);
            //p.email = collection["email"];
            p.dataConsulta = Convert.ToDateTime(collection["dataConsulta"]);
            _pacientes.AtualizaPaciente(p);
            return RedirectToAction("Index");
        }
    }
}