import React, { useState, FormEvent } from 'react';
import PageHeader from '../../components/PageHeader';
import TeacherItem, {Teacher} from '../../components/TeacherItem';
import Input from '../../components/Input'
import Select from '../../components/Select';
import api from '../../services/api';

import './styles.css'


const TeacherList: React.FC = () => {
  const [subject,setSubject] = useState('')
  const [weekday,setWeekday] = useState('')
  const [time,setTime] = useState('')
  const [teachers, setTeachers] = useState([])

  async function handleSearchTeacher(e: FormEvent){
    e.preventDefault();
    
    const response = await api.get('/classes',{
      params: {
        subject,
        week_day:weekday,
        time
      }
    });
    setTeachers(response.data.data);
  }
  return (
    <div id="page-teacher-list" className="container">
      <PageHeader title="Estes são os proffys disponíveis.">
        <form id="search-teachers" onSubmit={handleSearchTeacher}>
        <Select
            label="Matéria" 
            name="subject" 
            value={subject}
            onChange={(e) => { setSubject(e.target.value) }}
            options={[
              { value: 'Artes', label: 'Artes'},
              { value: 'Ciências', label: 'Ciências'},
              { value: 'Português', label: 'Português'},
              { value: 'Química', label: 'Química'},
              { value: 'Física', label: 'Física'},
            ]}  
          />
        <Select
            label="Dia da semana" 
            name="weekday" 
            value={weekday}
            onChange={(e) => { setWeekday(e.target.value) }}
            options={[
              { value: '0', label: 'Domingo'},
              { value: '1', label: 'Segunda-Feira'},
              { value: '2', label: 'Terça-Feira'},
              { value: '3', label: 'Quarta-Feira'},
              { value: '4', label: 'Quinta-Feira'},
              { value: '5', label: 'Sexta-Feira'},
              { value: '6', label: 'Sábado'},
            ]}  
          />
        <Input 
          type='time' 
          label="Hora" 
          name="time" 
          value={time}
          onChange={(e) => { setTime(e.target.value) }}
        />

        <button type='submit'>
          Buscar
        </button>
        </form> 
      </PageHeader>

      <main>
      {teachers.map((teacher: Teacher) => {
        return (
          <TeacherItem key={teacher.id} teacher={teacher}/>
        )
      })}
      </main>
    </div>
  );
}

export default TeacherList;