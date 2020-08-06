import React, { SelectHTMLAttributes } from 'react';

import './styles.css'
interface SelectProps extends SelectHTMLAttributes<HTMLSelectElement>{
  label: string;
  name:string;
  options: Array<{
    value:string;
    label:string;
  }>;
}
const Select: React.FC<SelectProps> = ({label,name,options, ...rest }) => {
  return (
    <div className="select-block">
      <label htmlFor={name}>{label}</label>
<<<<<<< HEAD
      <select defaultValue="" id={name} {...rest}>
        <option value="" disabled  hidden>Selecione uma opção</option>
=======
      <select id={name} {...rest}>
        <option value="" disabled selected hidden>Selecione uma opção</option>
>>>>>>> feature-back-end
        {options.map((x,i) => {
          return (
            <option key={i} value={x.value}>{x.label}</option>
          )
        })}
      </select>
    </div>
  );
}

export default Select;