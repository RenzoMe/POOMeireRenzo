using System.Collections.Generic;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class MenuRepository
    {
        private static MenuRepository? instancia;
        public static MenuRepository Instancia => instancia ??= new MenuRepository();

        private readonly List<MenuDto> menus;

        private MenuRepository()
        {
            menus = new List<MenuDto>
            {
                new MenuDto(1, "Menú Estándar", TipoMenu.Estandar, 20000m),
                new MenuDto(2, "Menú Celíaco", TipoMenu.Celiaco, 28000m),
                new MenuDto(3, "Menú Vegetariano", TipoMenu.Vegetariano, 17500m),
                new MenuDto(4, "Menú Diabético", TipoMenu.Diabetico, 19000m)
            };
        }

        public IEnumerable<MenuDto> ObtenerTodos()
        {
            return menus;
        }
    }
}