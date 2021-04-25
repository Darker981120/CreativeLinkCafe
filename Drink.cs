using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeLinkCafe
{
    // 饮品种类
    public enum DrinkType
    {
        Coffee, // 咖啡
        Beverage // 饮料
    }

    // 温度
    public enum Temperature
    {
        Ice, // 冷饮
        Hot // 热饮
    }

    // 杯子尺寸
    public enum CupSize
    {
        Small,
        Medium,
        Large
    }

    // 饮品类
    class Drink
    {
        private string m_name; // 名称
        private DrinkType m_drinkType; // 饮品的类型
        private Bean m_bean; // 使用的豆子
        private Temperature m_temperature; // 温度
        private CupSize m_cupSize; // 杯子尺寸
        private Formula m_formula; // 配方
        private float m_price; // 价格 

        public Drink(string name, DrinkType drinkType, Bean bean, Temperature temperature, CupSize cupSize, Formula formula, float price)
        {
            m_name = name;
            m_drinkType = drinkType;
            m_bean = bean;
            m_temperature = temperature;
            m_cupSize = cupSize;
            m_formula = formula;
            m_price = price;
        }

        public string Name { get => m_name; set => m_name = value; }
        public DrinkType DrinkType { get => m_drinkType; set => m_drinkType = value; }
        public Temperature Temperature { get => m_temperature; set => m_temperature = value; }
        public CupSize CupSize { get => m_cupSize; set => m_cupSize = value; }
        public float Price { get => m_price; set => m_price = value; }
        internal Bean Bean { get => m_bean; set => m_bean = value; }
        internal Formula Formula { get => m_formula; set => m_formula = value; }
    }
}
