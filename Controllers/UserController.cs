using Microsoft.AspNetCore.Mvc;
using senac_sjrp.Models;
using senac_sjrp.Repository;

namespace senac_pos_web_sjrp.Controllers
{
    [Route("[controller]")]
    public class UserController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository repository)
        {
            this._userRepository = repository;
        }
        public IActionResult Index()
        {
            var result = this._userRepository.GetAllUsers();

            return View(result);
        }

        [Route("details/{id}")]
        public IActionResult Detail(int id)
        {
            var result = this._userRepository.GetUserById(id);
            return View(result);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(User model)
        {
            if (!ModelState.IsValid)
                return View(model);

            this._userRepository.Save(model);

            this.ViewBag.Message = "Operação realizada com sucesso!";

            return RedirectToAction("Index");
        }
    }
}