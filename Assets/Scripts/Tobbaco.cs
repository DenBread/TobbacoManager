using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Класс табак
    /// </summary>
    public class Tobbaco : MonoBehaviour, IProduct
    {
        private string _nameTobbaco;
        private List<string> _namesTastes;

        /// <summary>
        /// Добавить табак
        /// </summary>
        /// <param name="namesTastes">Название табака</param>
        public void AddTobbaco(string namesTastes)
        {
            _nameTobbaco = namesTastes;
        }

        /// <summary>
        /// Добавить табак и вкусы
        /// </summary>
        /// <param name="nameTobbaco">Название табака</param>
        /// <param name="namesTastes">Название вкусов</param>
        public void AddTobbaco(string nameTobbaco, params string[] namesTastes)
        {
            this._nameTobbaco = nameTobbaco;
            this._namesTastes = namesTastes.ToList();
        }


        /// <summary>
        /// Добавить вкус табака
        /// </summary>
        /// <param name="nameTeste">Вкус табака</param>
        public void Add(string nameTeste)
        {
            _namesTastes.Add(nameTeste);
        }


        /// <summary>
        /// Удалить вкус табака
        /// </summary>
        /// <param name="nameTeste">Вкус табака</param>
        public void Remove(string nameTeste)
        {
            _namesTastes.Remove(nameTeste);
        }

        /// <summary>
        /// Показать табак и вкусы табака
        /// </summary>
        public void Show()
        {
            Debug.Log($"Название табака {_nameTobbaco}");

            foreach (var namesTaste in _namesTastes)
            {
                Debug.Log(namesTaste);
            }
        }
    }
}
