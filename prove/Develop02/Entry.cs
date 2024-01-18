    class Entry
    {
        public string _prompt;
        public string _response;
        public string _date;
        public string _time;

        public Entry(string prompt, string response, string date, string time)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
            _time = time;
        }

        public string GetPrompt()
        {
            return _prompt;
        }

        public string GetResponse()
        {
            return _response;
        }

        public string GetDate()
        {
            return _date;
        }

        public string GetTime()
        {
            return _time;
        }

        public override string ToString()
        {
            return $"Date: {_date} - Prompt: {_prompt} \n{_response}\n";
        }
    }
