﻿namespace OneToOneToManyToManyRelations.Default_Convesion.ManyToMany
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
