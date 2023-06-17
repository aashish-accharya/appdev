using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.application.DTO.UserDTO;

namespace week19.application.Common.Interface;

public interface IAuthentication
{
    Task<ResponseDTO> Register(UserRegisterRequestDTO model);
}
