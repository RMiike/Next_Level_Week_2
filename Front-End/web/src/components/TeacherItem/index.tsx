import React from 'react';
import whatsapp from '../../assets/images/icons/whatsapp.svg'

import './styles.css'
import api from '../../services/api';

interface User {
  id: number;
  name: string;
  avatar: string;
  whatsapp: string;
  bio: string;
}

export interface Teacher {
  id: number;
  subject: string;
  cost: number;
  userId: number;
  user: User;
}
export interface TeacherItemProps {
  teacher: Teacher;
}
const TeacherItem: React.FC<TeacherItemProps> = ({ teacher }) => {
  function createNewConnection(){
    api.post('/connections', {
      userId:teacher.userId
    }) 
  }
  return (
    <article className="teacher-item">
      <header>
        <img src={teacher.user.avatar} alt="avatar" />
        <div>
          <strong>{teacher.user.name}</strong>
          <span>{teacher.subject}</span>
        </div>
      </header>
      <p>{teacher.user.bio}</p>
      <footer>
        <p>Preço/hora
          <strong>
            {teacher.cost}
          </strong>
        </p>
        <a target='_blank' onClick={createNewConnection} href={`https://wa.me/${teacher.user.whatsapp}`} >
          <img src={whatsapp} alt="whatsapp" />
          Entrar em contato
      </a>
      </footer>
    </article>);
}

export default TeacherItem;