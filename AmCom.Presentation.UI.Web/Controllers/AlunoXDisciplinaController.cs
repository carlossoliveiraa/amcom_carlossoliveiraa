using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AmCom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AmCom.Presentation.UI.Web.Controllers
{
    public class AlunoXDisciplinaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                IEnumerable<Aluno> aluno = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");
                    var responseTask = client.GetAsync("aluno");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Aluno>>();
                        readTask.Wait();

                        aluno = readTask.Result;
                    }
                    else
                    {
                        aluno = Enumerable.Empty<Aluno>();

                        ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o adminsitrador do sistema");
                    }
                }
                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult AdicionarDisciplinas()
        {
            try
            {
                IEnumerable<Disciplina> disciplina = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");
                    var responseTask = client.GetAsync("disciplina");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Disciplina>>();
                        readTask.Wait();

                        disciplina = readTask.Result;
                    }
                    else
                    {
                        disciplina = Enumerable.Empty<Disciplina>();

                        ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o adminsitrador do sistema");
                    }
                }
                return View(disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult create(Disciplina disciplina)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}