import React from 'react';
import PageHeader from '../../components/PageHeader';
import Input from '../../components/Input';
import warningIcon from '../../assets/images/icons/warning.svg'
import './styles.css'
import TextArea from '../../components/TextArea';
import Select from '../../components/Select';

const TeacherForm: React.FC = () => {
  return (
    <div id="page-teacher-form" className="container">
      <PageHeader
        title='Que incrível que você quer dar aulas.'
        description='O primeiro passo, é preencher esse
    formulário de inscrição.'/>
      <main>
        <fieldset>
          <legend>Seus dados</legend>
          <Input label="Nome completo" name="name" />
          <Input label="Avatar" name="avatar" />
          <Input label="WhatsApp" name="whatsapp" />
          <TextArea name="bio" label="Biografia" />
        </fieldset>

        <fieldset>
          <legend>Sobre a aula</legend>
          <Select
            label="Matéria"
            name="subject"
            options={[
              { value: 'Artes', label: 'Artes' },
              { value: 'Ciências', label: 'Ciências' },
              { value: 'Português', label: 'Português' },
              { value: 'Química', label: 'Química' },
              { value: 'Física', label: 'Física' },
            ]}
          />
          <Input label="Custo da sua hora por aula" name="cost" />
        </fieldset>
        <fieldset>
          <legend>
            Horários disponíveis
            <button>+ Novo horário</button>
          </legend>
          <div className="schedule-item">
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
          <Input name='from' label='Das' type='time' />
          <Input name='to' label='Até' type='time' />
          </div>
        </fieldset>

        <footer>
          <p>
            <img src={warningIcon} alt="aviso importante" />
            Importante ! <br />
            Preencha todos os dados.
            </p>
          <button>
            Salvar cadastro
            </button>
        </footer>
      </main>
    </div>
  );
}

export default TeacherForm;