using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using AmCom.Domain.Entities;
using AmCom.Presentation.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmCom.Presentation.UI.Web.Controllers
{
    public class DisciplinaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
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

        public ActionResult Edit(int id)
        {
            try
            {
                Disciplina disciplina = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("disciplina?id=" + id.ToString());
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Disciplina>>();
                        readTask.Wait();
                        disciplina = readTask.Result.Where(x => x.Id == id).FirstOrDefault();
                    }
                }
                return View(disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                var disciplina = new Disciplina { DataCadastro = DateTime.Now };
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
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/disciplina");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync("disciplina", disciplina);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o administrador");

                return View(disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, [Bind]Disciplina disciplina)
        {
            try
            {
                if (id != disciplina.Id)
                {
                    return NotFound();
                }

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/disciplina");

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync("disciplina", disciplina);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o administrador");

                return View(disciplina);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");

                    //HTTP DELETE
                    var deleteTask = client.DeleteAsync("disciplina/" + id.ToString());
                    deleteTask.Wait();

                    var result = deleteTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}