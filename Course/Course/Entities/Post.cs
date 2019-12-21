using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {
    class Post {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> Coments { get; set; } = new List<Coment>();

        public Post() {

        }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComent(Coment comment) {
            Coments.Add(comment);
        }

        public void RemoveComents(Coment comment) {
            Coments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder(); // Classe que auxilia a montar string

            //AppendLine adiciona o conteudo e pua uma linha
            //Append adiciona o conteudo

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");
            foreach( Coment c in Coments) {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
