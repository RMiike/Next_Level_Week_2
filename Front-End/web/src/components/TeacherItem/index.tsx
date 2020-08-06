import React from 'react';
import whatsapp from '../../assets/images/icons/whatsapp.svg'

import './styles.css'
const TeacherItem: React.FC = () => {
  return (
    <article className="teacher-item">
    <header>
      <img src="https://media-exp1.licdn.com/dms/image/C4D03AQFAUVS43b9jiQ/profile-displayphoto-shrink_200_200/0?e=1602115200&v=beta&t=pzHTuQ24RfQp8wahMjcoqtEHYRGFegSc0oaJskhxeq8" alt="" />
      <div>
        <strong>Renato Miike</strong>
        <span>Química</span>
      </div>
    </header>
    <p>Entusiasta das melhores tecnologias de química avançada.
      <br />
      <br />
Apaixonado por explodir coisas em laboratório e por mudar a vida das pessoas através de experiências. Mais de 200.000 pessoas já passaram por uma das minhas explosões.
    </p>
    <footer>
      <p>Preço/hora
        <strong>
          R$ 80.00
        </strong>
      </p>
      <button>
        <img src={whatsapp} alt="whatsapp"/>
        Entrar em contato
      </button>
    </footer>
  </article>);
}

export default TeacherItem;