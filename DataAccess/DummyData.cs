using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    class DummyData {

        public DummyData() {

        }

        public List<Client.Entities.NoteData> GetNoteList() {
            var list = new List<Client.Entities.NoteData>();

            list.Add(CreateNote(1, "Title 1", "Body 1", DateTime.Now));
            list.Add(CreateNote(2, "Title 2", "Body 2", DateTime.Now));
            list.Add(CreateNote(3, "Title 3", "Body 3", DateTime.Now));
            list.Add(CreateNote(4, "Title 4", "Body 4", DateTime.Now));
            list.Add(CreateNote(5, "Title 5", "Body 5", DateTime.Now));

            return list;
        }

        public Client.Entities.NoteData GetNoteByID(int id) =>
            CreateNote(id, $"Title {id}", $"Body {id}", DateTime.Now);

        private Client.Entities.NoteData CreateNote(int id, string title, string body, DateTime modifiedDate) {
            var note = new Client.Entities.NoteData() {
                ID = id,
                Title = title,
                Body = body,
                ModifiedDate = modifiedDate
            };

            return note;
        }
    }
}
