import React from 'react';
import PageHeader from '../../components/PageHeader';
import TeacherItem from '../../components/TeacherItem';
import Input from '../../components/Input'
import Select from '../../components/Select';

import './styles.css'


const TeacherList: React.FC = () => {
  return (
    <div id="page-teacher-list" className="container">
      <PageHeader title="Estes são os proffys disponíveis.">
        <form id="search-teachers">
        <Select
            label="Matéria" 
            name="subject" 
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
        <Input type='time' label="Hora" name="time" />
        </form>
      </PageHeader>

      <main>
      <TeacherItem/>
      <TeacherItem/>

      <TeacherItem/>

      <TeacherItem/>


      </main>
    </div>
  );
}

export default TeacherList;