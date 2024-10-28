﻿using RopakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RopakProject.DataAccessLayer.Abstract
{
    public interface ISendMessageDal : IGenericDal<SendMessage>
    {
        public int GetSendMessageCount();
    }
}
