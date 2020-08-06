import React, { useState, FormEvent } from 'react';
import PageHeader from '../../components/PageHeader';
import Input from '../../components/Input';
import warningIcon from '../../assets/images/icons/warning.svg'
import TextArea from '../../components/TextArea';
import Select from '../../components/Select';
import api from '../../services/api';
import {useHistory} from 'react-router-dom'

import './styles.css'
const TeacherForm: React.FC = () => {
  var history = useHistory();
  const [name, setName] = useState('');
  const [avatar, setAvatar] = useState('');
  const [whatsapp, setWhatsapp] = useState('');
  const [bio, setBio] = useState('');
  const [subject, setSubject] = useState('');
  const [cost, setCost] = useState('');
  const [scheduleItems, setScheduleItems] = useState([{
    weekday: 0, from: "", to: ""
  }]);

  function addNewSchedule() {
    setScheduleItems([
      ...scheduleItems,
      {
        weekday: 0, from: "", to: ""
      }
    ])
  }

  function setScheduleItemValue(position:number, field:string, value: string){
    const newArray = scheduleItems.map((scheduleItem, index) => {
      if(index === position){
        return { ...scheduleItem, [field]: value}
      }
      return scheduleItem;
    }) 
    setScheduleItems(newArray);
  }

  function handleCreateClass(e: FormEvent) {
    e.preventDefault();
   
    api.post('/classes',{
      name,
      avatar,
      whatsapp,
      bio,
      subject,
      cost: Number(cost),
      schedule:scheduleItems
    }).then(()=>{
      alert('Cadastro realizado com sucesso!')
      history.push('/');
    }).catch((e)=>{
      alert('Erro no cadastro.')
    })

  }

  return (
    <div id="page-teacher-form" className="container">
      <PageHeader
        title='Que incrível que você quer dar aulas.'
        description='O primeiro passo, é preencher esse
        formulário de inscrição.'
      />
      <main>
        <form onSubmit={handleCreateClass}>
          <fieldset>
            <legend>Seus dados</legend>
            <Input
              label="Nome completo"
              name="name"
              value={name}
              onChange={(e) => { setName(e.target.value) }}
            />
            <Input
              label="Avatar"
              name="avatar"
              value={avatar}
              onChange={(e) => { setAvatar(e.target.value) }}
            />
            <Input
              label="WhatsApp"
              name="whatsapp"
              value={whatsapp}
              onChange={(e) => { setWhatsapp(e.target.value) }}
            />
            <TextArea
              label="Biografia"
              name="bio"
              value={bio}
              onChange={(e) => { setBio(e.target.value) }}
            />
          </fieldset>

          <fieldset>
            <legend>Sobre a aula</legend>
            <Select
              label="Matéria"
              name="subject"
              value={subject}
              onChange={(e) => { setSubject(e.target.value) }}
              options={[
                { value: 'Artes', label: 'Artes' },
                { value: 'Ciências', label: 'Ciências' },
                { value: 'Português', label: 'Português' },
                { value: 'Química', label: 'Química' },
                { value: 'Física', label: 'Física' },
              ]}
            />
            <Input
              label="Custo da sua hora por aula"
              name="cost"
              value={cost}
              onChange={(e) => { setCost(e.target.value) }}
            />
          </fieldset>
          <fieldset>
            <legend>
              Horários disponíveis
            <button  type='button' onClick={addNewSchedule}>+ Novo horário</button>
            </legend>
            {scheduleItems.map((scheduleItem, index) => {
              return (
                <div key={index} className="schedule-item">
                  <Select
                    label="Dia da semana"
                    name="weekday"
                    value={scheduleItem.weekday}
                    onChange={e => setScheduleItemValue(index, 'weekday', e.target.value)}
                    options={[
                      { value: '0', label: 'Domingo' },
                      { value: '1', label: 'Segunda-Feira' },
                      { value: '2', label: 'Terça-Feira' },
                      { value: '3', label: 'Quarta-Feira' },
                      { value: '4', label: 'Quinta-Feira' },
                      { value: '5', label: 'Sexta-Feira' },
                      { value: '6', label: 'Sábado' },
                    ]}
                  />
                  <Input 
                    name='from' 
                    label='Das' 
                    type='time' 
                    value={scheduleItem.from}
                    onChange={e => setScheduleItemValue(index, 'from', e.target.value)}
                  />
                  <Input 
                    name='to' 
                    label='Até' 
                    value={scheduleItem.to}
                    type='time' 
                    onChange={e => setScheduleItemValue(index, 'to', e.target.value)}
                  />
                </div>
              )
            })}
          </fieldset>

          <footer>
            <p>
              <img src={warningIcon} alt="aviso importante" />
            Importante ! <br />
            Preencha todos os dados.
            </p>
            <button type='submit'>
              Salvar cadastro
            </button>
          </footer>
        </form>
      </main>
    </div>
  );
}

export default TeacherForm;