using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine
{
    class Pharmacy
    {
        List<Medicine> medicines = new List<Medicine>();
        Medicine[] medicine;


        public int MedicineLimit;
        public Pharmacy(int medicinelimit)
        {
            MedicineLimit = medicinelimit;
        }

        public Pharmacy()
        {
        }

        public void AddMedicine(Medicine medicine)
        {
            if (medicines.Count == 0)
            {
                medicines.Add(medicine);
            }
            else
            {
                foreach (Medicine item in medicines)
                {
                    if (item.Count<MedicineLimit)
                    {
                        if (item.Name!=medicine.Name)
                        {
                            medicines.Add(medicine);
                        }
                        else
                        {
                            throw new MedicineAlreadyExistsException(" Medicine Already Exists");
                        }
                    }
                    else
                    {
                        throw new CapacityLimitExcepsion(" Capacity out of Limit");
                    }
                }
            }
            

            medicines.Add(medicine);
        }
        public void FilterMedicinesByPrice (double minPrice,double maxPrice)
        {
            
                foreach (var item in medicines)
                {
                    if (item.Price > minPrice && item.Price < maxPrice)
                    {
                        Console.WriteLine($"{item.Id} {item.Name} {item.Price} {item.Count} {item.IsDeleted}");
                    }

                }
            
        }
        public void DeleteMedicineByld(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null");
            }
            else
            {
                foreach (var item in medicines)
                {
                    if (item.Id == id && item.IsDeleted == false)
                    {
                        item.IsDeleted = true;
                    }

                }
            }
        }
        public void GetAllMedicines()
        {
            for (int i = 0; i < medicines.Capacity; i++)
            {
                int count = 0;
                if (medicines[i].IsDeleted == true)
                {

                    medicines.CopyTo(i, medicine, count, count);
                    count++;
                }


            }
            foreach (var item in medicine)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        public void EditMedicineEmail(int? id, string name)
        {
            if (id == null || name == null)
            {
                throw new NotFoundException("is not Found");
            }
            else
            {
                foreach (var item in medicines)
                {
                    if (item.Id == id && item.Name == name)
                    {
                        string NewName = Console.ReadLine();
                        item.Name = NewName;
                    }

                }
            }
        }
    }

}

