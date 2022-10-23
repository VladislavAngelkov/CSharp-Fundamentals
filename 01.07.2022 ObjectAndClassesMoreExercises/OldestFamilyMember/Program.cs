using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());

            Family family = new Family(new List<Member>());

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] memberInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = memberInfo[0];
                int age = int.Parse(memberInfo[1]);

                Member member = new Member();
                member.Name = name;
                member.Age = age;

                AddMember(member, family);
            }

            //Member oldestMember = OldestMember(family);

            Member oldestMember = family.FindOldest();

            Console.WriteLine(oldestMember);

        }

        public static void AddMember(Member member, Family family)
        {
            family.Members.Add(member);
        }

        public static Member OldestMember(Family family)
        {
            Member oldestMember = family.Members[family.Members.IndexOf(family.Members.First(x => x.Age == family.Members.Max(y => y.Age)))];

            return oldestMember;
        }
    }

    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string text = $"{this.Name} {this.Age}";

            return text;
        }
    }

    class Family
    {
        public Family(List<Member> members)
        {
            Members = members;
        }
        public List<Member> Members { get; set; }

        public  Member FindOldest()
        {
            Member oldestMember = this.Members[this.Members.IndexOf(this.Members.First(x => x.Age == this.Members.Max(y => y.Age)))];

            return oldestMember;
        }
    }
}
