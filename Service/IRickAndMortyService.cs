using NetworkAccessDetection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAccessDetection.Service
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonResponse>> Obtainer();
    }
}
