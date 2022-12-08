using DungeonInterfaces;

namespace DungeonLibrary
{
    public abstract class Character: Idamagable
    {
        private int _life;

        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else if (value > MaxLife)
                {
                    _life = MaxLife;
                }
                
            }


        }

        public Character()
        {
            
        }

        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }

        public virtual int CalcBlock()
        {
            int blockroll;
            Random random = new Random();
            blockroll = random.Next(20);
            return blockroll + Block;
        }

        public virtual int CalcHitChance()
        {
            int hitroll;
            Random random = new Random();
            hitroll = random.Next(20);
            return hitroll + HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n" +
                "Max Life: {1}\n" +
                "Life: {2}\n" +
                "Block: {3}\n" +
                "Hit Chance: {4}",
                Name,
                MaxLife,
                Life,
                Block,
                HitChance);
        }

    }

}