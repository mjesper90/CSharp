namespace PretendUnity{
    public class Transform 
    {
        private Vector3 position;
        
        public Vector3 GetPosition(){
            return position;
        }

        public void AddForce(Vector3 force){
            position.X += force.X;
            position.Y += force.Y;
            position.Z += force.Z;
        }
    }
}