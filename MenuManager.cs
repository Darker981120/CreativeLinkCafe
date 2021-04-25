using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeLinkCafe
{
    // 菜单管理
    class MenuManager
    {
        // 饮品菜单
        public Dictionary<string, Drink> drinkMenu = new Dictionary<string, Drink>();

        // 创建饮品菜单
        private void CreateDrinkMenu()
        {
            drinkMenu.Clear();
        }

        // 介绍一款饮品
        private void IntroADrink()
        {

        }
    }
}
