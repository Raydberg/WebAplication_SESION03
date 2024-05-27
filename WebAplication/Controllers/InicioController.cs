using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAplication.Datos;
using WebAplication.Models;

namespace WebAplication.Controllers
{
    public class InicioController : Controller
    {

        private readonly ApplicationDbContext _contexto;


        public InicioController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Contacto contacto, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                // Guardar la foto si se proporciona
                if (foto != null && foto.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await foto.CopyToAsync(stream);
                        contacto.Foto = stream.ToArray();
                    }
                }

                // Guardar el contacto en la base de datos
                contacto.FechaCreacion = DateTime.Now;
                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();

                // Redirigir a la acción Index después de guardar el contacto
                return RedirectToAction(nameof(Index));
            }

            // Si el modelo no es válido, volver a la vista del formulario de creación
            return View();
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var contacto = _contexto.Contacto.Find(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }

        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarRegistro(int? id)
        {
            var contacto = await _contexto.Contacto.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            _contexto.Contacto.Remove(contacto);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: InicioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InicioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InicioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InicioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InicioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InicioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InicioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}