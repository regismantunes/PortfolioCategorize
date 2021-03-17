using PortfolioCategorize_WinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PortfolioCategorize_WinForm.Control
{
    class CategoryCollection : IEnumerable<Category>
    {
        private readonly List<Category> _categories = new List<Category>();
        private readonly object _objLock = new object();
        public int Count => _categories.Count;

        public CategoryCollection()
        { }

        public CategoryCollection(IEnumerable<Category> categories)
        {
            try
            {
                foreach (Category category in categories)
                    Add(category);
            }
            catch (Exception ex)
            {
                _categories.Clear();
                throw ex;
            }
        }
        
        public void Add(Category category)
        {
            lock (_objLock)
            {
                Category conflictCategory = _categories.FirstOrDefault(item => item.ClientSector.ToLower() == category.ClientSector.ToLower()
                                                                            && item.MinimumValue <= category.MaximumValue
                                                                            && item.MaximumValue >= category.MinimumValue);
                if (conflictCategory != null)
                    throw new InvalidOperationException($"Added category conflicted with the existing category {conflictCategory.Name}");

                _categories.Add(category);
            }
        }

        public void Remove(Category category)
        {
            lock (_objLock)
            {
                _categories.Remove(category);
            }
        }

        public IEnumerator<Category> GetEnumerator() => _categories.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _categories.GetEnumerator();

        public static CategoryCollection GetDefaultCategories()
        {
            Category[] categoriesPreDef = { Category.CreateCategoryLessThan("LOWRISK", 1000000, "Public"),
                                            Category.CreateCategoryGreaterThan("MEDIUMRISK", 1000000.01, "Public"),
                                            Category.CreateCategoryGreaterThan("HIGHRISK", 1000000, "Private") };

            return new CategoryCollection(categoriesPreDef);
        }
    }
}
