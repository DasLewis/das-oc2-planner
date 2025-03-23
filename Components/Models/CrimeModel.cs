using static OC2._0_Planner.Components.Pages.Faction;

namespace OC2._0_Planner.Components.Models
{
    public class OCData()
    {
        public List<Crime> crimes { get; set; }
        public _Metadata _metadata { get; set; }
    }

    public class CrimeContainer()
    {
        public Crime? crime { get; set; }
        public bool opened { get; set; }
    }

    public class Crime()
    {
        public int id { get; set; }
        public string name { get; set; }
        public int difficulty { get; set; }
        public string? status { get; set; }
        public int? created_at { get; set; }
        public int? planning_at { get; set; }
        public int? executed_at { get; set; }
        public int ready_at { get; set; }
        public int expired_at { get; set; }
        public List<CrimeSlot> slots { get; set; }
        public Rewards rewards { get; set; }
    }

    public class CrimeSlot()
    {
        public string position { get; set; }
        public ItemRequirement? item_requirement { get; set; }
        public int user_id { get; set; }
        public User user { get; set; }
        public int success_chance { get; set; }
        public int crime_pass_rate { get; set; }
    }

    public class ItemRequirement()
    {
        public int id { get; set; }
        public bool is_reusable { get; set; }
        public bool is_available { get; set; }
    }

    public class User()
    {
        public int id { get; set; }
        public int joined_at { get; set; }
        public int progress { get; set; }
    }

    public class Rewards()
    {
        public int? money { get; set; }
        public List<Item>? items { get; set; }
        public int respect { get; set; }
        public Payout? payout { get; set; }
    }

    public class Item()
    {
        public int id { get; set; }
        public int quantity { get; set; }
    }

    public class Payout()
    {
        public string type { get; set; }
        public int percentage { get; set; }
        public int paid_by { get; set; }
        public int paid_at { get; set; }
    }

    public class _Metadata()
    {
        public string? prev { get; set; }
        public string? next { get; set; }
        public Links links { get; set; }
    }

    public class Links()
    {
        public string? next { get; set; }
        public string? prev { get; set; }
    }

    public class DetailedItems()
    {
        public List<DetailedItem> items { get; set; }
    }
    public class DetailedItem()
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string effect { get; set; }
        public string? requirement { get; set; }
        public string image { get; set; }
        public string type { get; set; }
        public string? sub_type { get; set; }
        public bool is_masked { get; set; }
        public bool is_tradable { get; set; }
        public bool is_found_in_city { get; set; }
        public ItemValue value { get; set; }
        public int circulation { get; set; }
        public string? details { get; set; }
    }

    public class ItemValue()
    {
        public Vendor vendor { get; set; }
        public int? buy_price { get; set; }
        public int? sell_price { get; set; }
        public int? market_price { get; set; }
    }

    public class Vendor()
    {
        public string country { get; set; }
        public string name { get; set; }
    }
    public class FactionMember()
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class FactionMembers()
    {
        public List<FactionMember> members { get; set; }
    }

    public class EmancipatedCrimeSlot()
    {
        public int? executed_at { get; set; }
        public CrimeSlot crimeSlot { get; set; }
        public string userName { get; set; }
        public string crimeName { get; set; }
        public int difficulty { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is EmancipatedCrimeSlot)
            {
                EmancipatedCrimeSlot o = (EmancipatedCrimeSlot)obj;
                return (crimeSlot.user_id == o.crimeSlot.user_id && crimeSlot.position == o.crimeSlot.position && crimeName.Equals(o.crimeName));
            }
            else
            {
                return base.Equals(obj);
            }
        }
    }
}
